import { Schema, type } from "@colyseus/schema";
import { Client } from "colyseus";

export class Player extends Schema {

    clientID: string;

    @type("string") playerID: string;
    @type("string") playerName: string;

    @type("number") balance: number;

    @type("boolean") isObserver: boolean = false;

    setPlayer(client: Client) {
        this.clientID = client.id;
    }
}