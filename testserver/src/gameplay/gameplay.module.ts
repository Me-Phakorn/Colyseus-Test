import { Module } from '@nestjs/common';
import { GameplayService } from './gameplay.service';

@Module({
  imports: [

  ],

  providers: [
    GameplayService,
  ],

  exports: [],
  controllers: [],
})
export class GameplayModule { }
