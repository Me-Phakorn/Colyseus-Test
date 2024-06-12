// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Shoe : Schema {
	[Type(0, "string")]
	public string shoeID = default(string);

	[Type(1, "string")]
	public string tableID = default(string);

	[Type(2, "boolean")]
	public bool isDrawRedCard = default(bool);

	[Type(3, "number")]
	public float totalCards = default(float);

	[Type(4, "number")]
	public float redCardPosition = default(float);

	[Type(5, "number")]
	public float numberOfDecks = default(float);

	[Type(6, "number")]
	public float cutCardsCount = default(float);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __shoeIDChange;
	public Action OnShoeIDChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.shoeID));
		__shoeIDChange += __handler;
		if (__immediate && this.shoeID != default(string)) { __handler(this.shoeID, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(shoeID));
			__shoeIDChange -= __handler;
		};
	}

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

	protected event PropertyChangeHandler<bool> __isDrawRedCardChange;
	public Action OnIsDrawRedCardChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.isDrawRedCard));
		__isDrawRedCardChange += __handler;
		if (__immediate && this.isDrawRedCard != default(bool)) { __handler(this.isDrawRedCard, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(isDrawRedCard));
			__isDrawRedCardChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __totalCardsChange;
	public Action OnTotalCardsChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.totalCards));
		__totalCardsChange += __handler;
		if (__immediate && this.totalCards != default(float)) { __handler(this.totalCards, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(totalCards));
			__totalCardsChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __redCardPositionChange;
	public Action OnRedCardPositionChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.redCardPosition));
		__redCardPositionChange += __handler;
		if (__immediate && this.redCardPosition != default(float)) { __handler(this.redCardPosition, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(redCardPosition));
			__redCardPositionChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __numberOfDecksChange;
	public Action OnNumberOfDecksChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.numberOfDecks));
		__numberOfDecksChange += __handler;
		if (__immediate && this.numberOfDecks != default(float)) { __handler(this.numberOfDecks, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(numberOfDecks));
			__numberOfDecksChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __cutCardsCountChange;
	public Action OnCutCardsCountChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.cutCardsCount));
		__cutCardsCountChange += __handler;
		if (__immediate && this.cutCardsCount != default(float)) { __handler(this.cutCardsCount, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(cutCardsCount));
			__cutCardsCountChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(shoeID): __shoeIDChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(tableID): __tableIDChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(isDrawRedCard): __isDrawRedCardChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			case nameof(totalCards): __totalCardsChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(redCardPosition): __redCardPositionChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(numberOfDecks): __numberOfDecksChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(cutCardsCount): __cutCardsCountChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			default: break;
		}
	}
}

