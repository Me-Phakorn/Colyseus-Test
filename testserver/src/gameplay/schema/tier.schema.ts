import { ArraySchema, Schema, type } from "@colyseus/schema";

export class Tier extends Schema {
    @type("string") tireId: string;
    @type("string") tireName: string;
    @type("number") minBet: number;
    @type("number") maxBet: number;
    @type("number") maxTable: number;
    @type("number") perfectBet: number = 1;
    @type("number") plusThreeBet: number = 1;
    @type("number") maxObserver: number = 10;
    @type("number") maxShoe: number = 5;
    @type("number") redCardPosition: number = 100;
    @type("number") max_winrate: number = 55;
    @type("number") min_win_round: number = 1;
    @type("number") max_win_round: number = 10;
    @type("number") win_immune_round: number = 55;

    @type("boolean") multiplayer: boolean = false;

    tableList = [];

    constructor(
        tireId: string,
        tireName: string,
        multiplayer: boolean,
        minBet: number,
        maxBet: number,
        maxTable: number,
        perfectBet: number = 1,
        plusThreeBet: number = 1,
        maxObserver: number = 10,
        maxShoe: number = 5,
        redCardPosition: number = 100,
        max_winrate: number = 55,
        min_win_round: number = 1,
        max_win_round: number = 10,
        win_immune_round: number = 55,
    ) {
        super();
        this.tireId = tireId;
        this.tireName = tireName;
        this.minBet = minBet;
        this.maxBet = maxBet;
        this.maxTable = maxTable;
        this.perfectBet = perfectBet;
        this.plusThreeBet = plusThreeBet;
        this.maxObserver = maxObserver;
        this.maxShoe = maxShoe;
        this.redCardPosition = redCardPosition;
        this.max_winrate = max_winrate;
        this.min_win_round = min_win_round;
        this.max_win_round = max_win_round;
        this.win_immune_round = win_immune_round;
        this.multiplayer = multiplayer;

        for (let i = 1; i <= maxTable; i++) {
            const tableID = `${multiplayer ? 'M' : 'P'}_${parseInt(tireId.split('_')[1]) * 1000 + i}`;
            this.tableList.push(tableID);
        }
    }

    getTableList() {
        return this.tableList;
    }
}