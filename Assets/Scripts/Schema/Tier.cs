// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Tier : Schema {
	[Type(0, "string")]
	public string tireId = default(string);

	[Type(1, "string")]
	public string tireName = default(string);

	[Type(2, "number")]
	public float minBet = default(float);

	[Type(3, "number")]
	public float maxBet = default(float);

	[Type(4, "number")]
	public float maxTable = default(float);

	[Type(5, "number")]
	public float perfectBet = default(float);

	[Type(6, "number")]
	public float plusThreeBet = default(float);

	[Type(7, "number")]
	public float maxObserver = default(float);

	[Type(8, "number")]
	public float maxShoe = default(float);

	[Type(9, "number")]
	public float redCardPosition = default(float);

	[Type(10, "number")]
	public float max_winrate = default(float);

	[Type(11, "number")]
	public float min_win_round = default(float);

	[Type(12, "number")]
	public float max_win_round = default(float);

	[Type(13, "number")]
	public float win_immune_round = default(float);

	[Type(14, "boolean")]
	public bool multiplayer = default(bool);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __tireIdChange;
	public Action OnTireIdChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.tireId));
		__tireIdChange += __handler;
		if (__immediate && this.tireId != default(string)) { __handler(this.tireId, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(tireId));
			__tireIdChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __tireNameChange;
	public Action OnTireNameChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.tireName));
		__tireNameChange += __handler;
		if (__immediate && this.tireName != default(string)) { __handler(this.tireName, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(tireName));
			__tireNameChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __minBetChange;
	public Action OnMinBetChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.minBet));
		__minBetChange += __handler;
		if (__immediate && this.minBet != default(float)) { __handler(this.minBet, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(minBet));
			__minBetChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __maxBetChange;
	public Action OnMaxBetChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.maxBet));
		__maxBetChange += __handler;
		if (__immediate && this.maxBet != default(float)) { __handler(this.maxBet, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(maxBet));
			__maxBetChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __maxTableChange;
	public Action OnMaxTableChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.maxTable));
		__maxTableChange += __handler;
		if (__immediate && this.maxTable != default(float)) { __handler(this.maxTable, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(maxTable));
			__maxTableChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __perfectBetChange;
	public Action OnPerfectBetChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.perfectBet));
		__perfectBetChange += __handler;
		if (__immediate && this.perfectBet != default(float)) { __handler(this.perfectBet, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(perfectBet));
			__perfectBetChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __plusThreeBetChange;
	public Action OnPlusThreeBetChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.plusThreeBet));
		__plusThreeBetChange += __handler;
		if (__immediate && this.plusThreeBet != default(float)) { __handler(this.plusThreeBet, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(plusThreeBet));
			__plusThreeBetChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __maxObserverChange;
	public Action OnMaxObserverChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.maxObserver));
		__maxObserverChange += __handler;
		if (__immediate && this.maxObserver != default(float)) { __handler(this.maxObserver, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(maxObserver));
			__maxObserverChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __maxShoeChange;
	public Action OnMaxShoeChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.maxShoe));
		__maxShoeChange += __handler;
		if (__immediate && this.maxShoe != default(float)) { __handler(this.maxShoe, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(maxShoe));
			__maxShoeChange -= __handler;
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

	protected event PropertyChangeHandler<float> __max_winrateChange;
	public Action OnMax_winrateChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.max_winrate));
		__max_winrateChange += __handler;
		if (__immediate && this.max_winrate != default(float)) { __handler(this.max_winrate, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(max_winrate));
			__max_winrateChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __min_win_roundChange;
	public Action OnMin_win_roundChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.min_win_round));
		__min_win_roundChange += __handler;
		if (__immediate && this.min_win_round != default(float)) { __handler(this.min_win_round, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(min_win_round));
			__min_win_roundChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __max_win_roundChange;
	public Action OnMax_win_roundChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.max_win_round));
		__max_win_roundChange += __handler;
		if (__immediate && this.max_win_round != default(float)) { __handler(this.max_win_round, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(max_win_round));
			__max_win_roundChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __win_immune_roundChange;
	public Action OnWin_immune_roundChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.win_immune_round));
		__win_immune_roundChange += __handler;
		if (__immediate && this.win_immune_round != default(float)) { __handler(this.win_immune_round, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(win_immune_round));
			__win_immune_roundChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __multiplayerChange;
	public Action OnMultiplayerChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.multiplayer));
		__multiplayerChange += __handler;
		if (__immediate && this.multiplayer != default(bool)) { __handler(this.multiplayer, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(multiplayer));
			__multiplayerChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(tireId): __tireIdChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(tireName): __tireNameChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(minBet): __minBetChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(maxBet): __maxBetChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(maxTable): __maxTableChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(perfectBet): __perfectBetChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(plusThreeBet): __plusThreeBetChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(maxObserver): __maxObserverChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(maxShoe): __maxShoeChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(redCardPosition): __redCardPositionChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(max_winrate): __max_winrateChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(min_win_round): __min_win_roundChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(max_win_round): __max_win_roundChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(win_immune_round): __win_immune_roundChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(multiplayer): __multiplayerChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			default: break;
		}
	}
}

