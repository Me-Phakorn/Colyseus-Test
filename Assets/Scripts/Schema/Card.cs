// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Card : Schema {
	[Type(0, "string")]
	public string suit = default(string);

	[Type(1, "string")]
	public string value = default(string);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __suitChange;
	public Action OnSuitChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.suit));
		__suitChange += __handler;
		if (__immediate && this.suit != default(string)) { __handler(this.suit, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(suit));
			__suitChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __valueChange;
	public Action OnValueChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.value));
		__valueChange += __handler;
		if (__immediate && this.value != default(string)) { __handler(this.value, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(value));
			__valueChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(suit): __suitChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(value): __valueChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			default: break;
		}
	}
}

