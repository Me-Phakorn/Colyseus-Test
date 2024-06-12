// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Shoes : Schema {
	[Type(0, "ref", typeof(Shoe))]
	public Shoe shoe = new Shoe();

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<Shoe> __shoeChange;
	public Action OnShoeChange(PropertyChangeHandler<Shoe> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.shoe));
		__shoeChange += __handler;
		if (__immediate && this.shoe != null) { __handler(this.shoe, null); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(shoe));
			__shoeChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(shoe): __shoeChange?.Invoke((Shoe) change.Value, (Shoe) change.PreviousValue); break;
			default: break;
		}
	}
}

