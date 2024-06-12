import { Injectable, OnModuleInit, OnModuleDestroy } from '@nestjs/common';
import { Server, matchMaker } from 'colyseus';
import { createServer } from 'http';
import { WebSocketTransport } from '@colyseus/ws-transport';

import { TableRoom } from './room/table.room';
import { GAME_CONFIG } from './config/game.config';

@Injectable()
export class GameplayService implements OnModuleInit, OnModuleDestroy {
  private server: Server;

  async onModuleInit() {
    const httpServer = createServer();

    this.server = new Server({
      transport: new WebSocketTransport({
        server: httpServer,
        pingInterval: 5000,
        pingMaxRetries: 3,
        verifyClient: (info, done) => done(true),
      }),

    });

    this.server.define(GAME_CONFIG.GAME_NAME, TableRoom);

    const tableID = 'P_1001';
    await matchMaker.createRoom(GAME_CONFIG.GAME_NAME, { tableID });

    httpServer.listen(GAME_CONFIG.SERVER_PORT, () => {
      console.log('Colyseus is running on port ' + GAME_CONFIG.SERVER_PORT);
    });
  }

  onModuleDestroy() {
    this.server.gracefullyShutdown();
    this.server.removeRoomType(GAME_CONFIG.GAME_NAME);
  }

}
