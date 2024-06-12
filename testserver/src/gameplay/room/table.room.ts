import { Client, Room } from "colyseus";
import { Table } from "../schema/table.schema";
import { GAME_MESSAGE } from "../config/game.config";
import { Player } from "../schema/player.schema";

export class TableRoom extends Room<Table> {

    onCreate(options: any) {
        this.setState(new Table(options.tableID));

        this.roomId = options.tableID;
        this.autoDispose = false;

        console.log("Table created!", this.roomId);

        // this.onMessage(GAME_MESSAGE.JOIN_SEAT, this.joinSeat.bind(this));
        // this.onMessage(GAME_MESSAGE.LEAVE_SEAT, this.joinSeat.bind(this));
    }

    async onAuth(client: Client, options: any, request: any) {
        console.log('onAuth', options);
        return true;
    }

    onJoin(client: Client, options: any) {
        console.log('client joined', client.sessionId);

        const player = new Player();
        this.state.observers.set(client.sessionId, player);
    }

    onLeave(client: Client, consented: boolean) {
        console.log('client left', client.sessionId);
    }

    onDispose() {
        console.log('room disposed');
    }

}