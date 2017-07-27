var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Account = (function () {
    function Account(anum, aname, abal) {
        this.anum = anum;
        this.aname = aname;
        this.abal = abal;
    }
    Account.prototype.getBal = function () {
        return (this.abal);
    };
    return Account;
}());
var SavingsAccount = (function (_super) {
    __extends(SavingsAccount, _super);
    function SavingsAccount(anum, aname, abal, aint) {
        var _this = _super.call(this, anum, aname, abal) || this;
        _this.aint = aint;
        return _this;
    }
    SavingsAccount.prototype.getBal = function () {
        return (_super.prototype.getBal.call(this) + this.aint);
    };
    return SavingsAccount;
}(Account));
var CurrentAccount = (function (_super) {
    __extends(CurrentAccount, _super);
    function CurrentAccount(anum, aname, abal, acash) {
        var _this = _super.call(this, anum, aname, abal) || this;
        _this.acash = acash;
        return _this;
    }
    CurrentAccount.prototype.getBal = function () {
        return (_super.prototype.getBal.call(this) + this.acash);
    };
    return CurrentAccount;
}(Account));
function getCashOfBank() {
    var account = [212, 214, 236, 547, 564];
    var totAcntCash = 0;
    var savAcnt;
    var curAcnt;
    for (var i in account) {
        savAcnt = new SavingsAccount(account[i], 'raj', (i * 100), (i / 100));
        curAcnt = new CurrentAccount(account[i], "raj", (i * 10), (i / 10));
        totAcntCash = totAcntCash + (savAcnt.getBal() + curAcnt.getBal());
    }
    console.log(totAcntCash);
}
getCashOfBank();
