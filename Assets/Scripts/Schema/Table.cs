// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Table : Schema {
	[Type(0, "string")]
	public string tableID = default(string);

	[Type(1, "map", typeof(MapSchema<Player>))]
	public MapSchema<Player> observers = new MapSchema<Player>();

	[Type(2, "ref", typeof(Shoes))]
	public Shoes shoes = new Shoes();

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __tableIDChange;
	public Action OnTableIDChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.tableID));
		__tableIDChange += __handler;
		if (__immediate && this.tableID != default(string)) { __handler(this.tableID, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(tableID));
			__tableIDChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<MapSchema<Player>> __observersChange;
	public Action OnObserversChange(PropertyChangeHandler<MapSchema<Player>> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.observers));
		__observersChange += __handler;
		if (__immediate && this.observers != null) { __handler(this.observers, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(observers));
			__observersChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<Shoes> __shoesChange;
	public Action OnShoesChange(PropertyChangeHandler<Shoes> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.shoes));
		__shoesChange += __handler;
		if (__immediate && this.shoes != null) { __handler(this.shoes, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(shoes));
			__shoesChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(tableID): __tableIDChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(observers): __observersChange?.Invoke((MapSchema<Player>) change.Value, (MapSchema<Player>) change.PreviousValue); break;
			case nameof(shoes): __shoesChange?.Invoke((Shoes) change.Value, (Shoes) change.PreviousValue); break;
			default: break;
		}
	}
}

