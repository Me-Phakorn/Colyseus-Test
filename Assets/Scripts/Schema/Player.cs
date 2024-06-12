// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 2.0.32
// 

using Colyseus.Schema;
using Action = System.Action;

public partial class Player : Schema {
	[Type(0, "string")]
	public string playerID = default(string);

	[Type(1, "string")]
	public string playerName = default(string);

	[Type(2, "number")]
	public float balance = default(float);

	[Type(3, "boolean")]
	public bool isObserver = default(bool);

	/*
	 * Support for individual property change callbacks below...
	 */

	protected event PropertyChangeHandler<string> __playerIDChange;
	public Action OnPlayerIDChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.playerID));
		__playerIDChange += __handler;
		if (__immediate && this.playerID != default(string)) { __handler(this.playerID, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(playerID));
			__playerIDChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<string> __playerNameChange;
	public Action OnPlayerNameChange(PropertyChangeHandler<string> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.playerName));
		__playerNameChange += __handler;
		if (__immediate && this.playerName != default(string)) { __handler(this.playerName, default(string)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(playerName));
			__playerNameChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<float> __balanceChange;
	public Action OnBalanceChange(PropertyChangeHandler<float> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.balance));
		__balanceChange += __handler;
		if (__immediate && this.balance != default(float)) { __handler(this.balance, default(float)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(balance));
			__balanceChange -= __handler;
		};
	}

	protected event PropertyChangeHandler<bool> __isObserverChange;
	public Action OnIsObserverChange(PropertyChangeHandler<bool> __handler, bool __immediate = true) {
		if (__callbacks == null) { __callbacks = new SchemaCallbacks(); }
		__callbacks.AddPropertyCallback(nameof(this.isObserver));
		__isObserverChange += __handler;
		if (__immediate && this.isObserver != default(bool)) { __handler(this.isObserver, default(bool)); }
		return () => {
			__callbacks.RemovePropertyCallback(nameof(isObserver));
			__isObserverChange -= __handler;
		};
	}

	protected override void TriggerFieldChange(DataChange change) {
		switch (change.Field) {
			case nameof(playerID): __playerIDChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(playerName): __playerNameChange?.Invoke((string) change.Value, (string) change.PreviousValue); break;
			case nameof(balance): __balanceChange?.Invoke((float) change.Value, (float) change.PreviousValue); break;
			case nameof(isObserver): __isObserverChange?.Invoke((bool) change.Value, (bool) change.PreviousValue); break;
			default: break;
		}
	}
}

