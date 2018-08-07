function RTW_Sid2UrlHash() {
	this.urlHashMap = new Array();
	/* <S1>/Data Type Conversion */
	this.urlHashMap["Test:1:114"] = "Digital.c:32,45";
	/* <S1>/Digital Output */
	this.urlHashMap["Test:1:214"] = "Digital.c:47,54";
	this.getUrlHash = function(sid) { return this.urlHashMap[sid];}
}
RTW_Sid2UrlHash.instance = new RTW_Sid2UrlHash();
function RTW_rtwnameSIDMap() {
	this.rtwnameHashMap = new Array();
	this.sidHashMap = new Array();
	this.rtwnameHashMap["<Root>"] = {sid: "Digital"};
	this.sidHashMap["Digital"] = {rtwname: "<Root>"};
	this.rtwnameHashMap["<S1>"] = {sid: "Test:1"};
	this.sidHashMap["Test:1"] = {rtwname: "<S1>"};
	this.rtwnameHashMap["<S1>/In1"] = {sid: "Test:1:116"};
	this.sidHashMap["Test:1:116"] = {rtwname: "<S1>/In1"};
	this.rtwnameHashMap["<S1>/Data Type Conversion"] = {sid: "Test:1:114"};
	this.sidHashMap["Test:1:114"] = {rtwname: "<S1>/Data Type Conversion"};
	this.rtwnameHashMap["<S1>/Digital Output"] = {sid: "Test:1:214"};
	this.sidHashMap["Test:1:214"] = {rtwname: "<S1>/Digital Output"};
	this.getSID = function(rtwname) { return this.rtwnameHashMap[rtwname];}
	this.getRtwname = function(sid) { return this.sidHashMap[sid];}
}
RTW_rtwnameSIDMap.instance = new RTW_rtwnameSIDMap();
