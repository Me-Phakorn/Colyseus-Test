import { ArraySchema, MapSchema, Schema, type } from "@colyseus/schema";
import { Tier } from "./tier.schema";
import { Shoes } from "./shoes.schema";
import { Player } from "./player.schema";

export class Table extends Schema {
    @type("string") tableID: string;

    @type({ map: Player }) observers = new MapSchema<Player>();

    @type(Shoes) shoes: Shoes;

    constructor(tableID: string) {
        super();

        this.tableID = tableID;
    }
}