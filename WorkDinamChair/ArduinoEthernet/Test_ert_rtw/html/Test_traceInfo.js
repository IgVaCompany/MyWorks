function RTW_Sid2UrlHash() {
	this.urlHashMap = new Array();
	/* <Root>/Chart */
	this.urlHashMap["Test:6"] = "Test.c:20,106,139&Test.h:48,55,56";
	/* <Root>/Chart1 */
	this.urlHashMap["Test:18"] = "Test.c:163,212&Test.h:47,53,54";
	/* <Root>/Gain */
	this.urlHashMap["Test:19"] = "Test.c:157";
	/* <Root>/Scope */
	this.urlHashMap["Test:8"] = "msg=rtwMsg_reducedBlock&block=Test/Scope";
	/* <Root>/Scope1 */
	this.urlHashMap["Test:17"] = "msg=rtwMsg_reducedBlock&block=Test/Scope1";
	/* <S1>/Output */
	this.urlHashMap["Test:9:1"] = "Test.c:101";
	/* <S1>/White Noise */
	this.urlHashMap["Test:9:2"] = "Test.c:102,234,248&Test.h:49,51";
	/* <S2>/Output */
	this.urlHashMap["Test:16:1"] = "Test.c:158";
	/* <S2>/White Noise */
	this.urlHashMap["Test:16:2"] = "Test.c:159,230,252&Test.h:50,52";
	/* <S3>:2 */
	this.urlHashMap["Test:6:2"] = "Test.c:120,134";
	/* <S3>:1 */
	this.urlHashMap["Test:6:1"] = "Test.c:117,125,129";
	/* <S3>:5 */
	this.urlHashMap["Test:6:5"] = "Test.c:114";
	/* <S3>:3 */
	this.urlHashMap["Test:6:3"] = "Test.c:131";
	/* <S3>:4 */
	this.urlHashMap["Test:6:4"] = "Test.c:122";
	/* <S4>:2 */
	this.urlHashMap["Test:18:2"] = "Test.c:177,189,199";
	/* <S4>:1 */
	this.urlHashMap["Test:18:1"] = "Test.c:174,182,194,206";
	/* <S4>:5 */
	this.urlHashMap["Test:18:5"] = "Test.c:171";
	/* <S4>:3 */
	this.urlHashMap["Test:18:3"] = "Test.c:196";
	/* <S4>:4 */
	this.urlHashMap["Test:18:4"] = "Test.c:179";
	/* <S4>:9 */
	this.urlHashMap["Test:18:9"] = "Test.c:186";
	/* <S4>:8 */
	this.urlHashMap["Test:18:8"] = "Test.c:203";
	/* <S5>/Data Type Conversion */
	this.urlHashMap["Test:1:114"] = "Test.c:141,152";
	/* <S5>/Digital Output */
	this.urlHashMap["Test:1:214"] = "Test.c:154,242";
	/* <S6>/Data Type Conversion */
	this.urlHashMap["Test:15:114"] = "Test.c:214,225";
	/* <S6>/PWM */
	this.urlHashMap["Test:15:215"] = "Test.c:227,245";
	this.getUrlHash = function(sid) { return this.urlHashMap[sid];}
}
RTW_Sid2UrlHash.instance = new RTW_Sid2UrlHash();
function RTW_rtwnameSIDMap() {
	this.rtwnameHashMap = new Array();
	this.sidHashMap = new Array();
	this.rtwnameHashMap["<Root>"] = {sid: "Test"};
	this.sidHashMap["Test"] = {rtwname: "<Root>"};
	this.rtwnameHashMap["<S1>"] = {sid: "Test:9"};
	this.sidHashMap["Test:9"] = {rtwname: "<S1>"};
	this.rtwnameHashMap["<S2>"] = {sid: "Test:16"};
	this.sidHashMap["Test:16"] = {rtwname: "<S2>"};
	this.rtwnameHashMap["<S3>"] = {sid: "Test:6"};
	this.sidHashMap["Test:6"] = {rtwname: "<S3>"};
	this.rtwnameHashMap["<S4>"] = {sid: "Test:18"};
	this.sidHashMap["Test:18"] = {rtwname: "<S4>"};
	this.rtwnameHashMap["<S5>"] = {sid: "Test:1"};
	this.sidHashMap["Test:1"] = {rtwname: "<S5>"};
	this.rtwnameHashMap["<S6>"] = {sid: "Test:15"};
	this.sidHashMap["Test:15"] = {rtwname: "<S6>"};
	this.rtwnameHashMap["<Root>/Band-Limited White Noise"] = {sid: "Test:9"};
	this.sidHashMap["Test:9"] = {rtwname: "<Root>/Band-Limited White Noise"};
	this.rtwnameHashMap["<Root>/Band-Limited White Noise1"] = {sid: "Test:16"};
	this.sidHashMap["Test:16"] = {rtwname: "<Root>/Band-Limited White Noise1"};
	this.rtwnameHashMap["<Root>/Chart"] = {sid: "Test:6"};
	this.sidHashMap["Test:6"] = {rtwname: "<Root>/Chart"};
	this.rtwnameHashMap["<Root>/Chart1"] = {sid: "Test:18"};
	this.sidHashMap["Test:18"] = {rtwname: "<Root>/Chart1"};
	this.rtwnameHashMap["<Root>/Digital Output"] = {sid: "Test:1"};
	this.sidHashMap["Test:1"] = {rtwname: "<Root>/Digital Output"};
	this.rtwnameHashMap["<Root>/Gain"] = {sid: "Test:19"};
	this.sidHashMap["Test:19"] = {rtwname: "<Root>/Gain"};
	this.rtwnameHashMap["<Root>/PWM"] = {sid: "Test:15"};
	this.sidHashMap["Test:15"] = {rtwname: "<Root>/PWM"};
	this.rtwnameHashMap["<Root>/Scope"] = {sid: "Test:8"};
	this.sidHashMap["Test:8"] = {rtwname: "<Root>/Scope"};
	this.rtwnameHashMap["<Root>/Scope1"] = {sid: "Test:17"};
	this.sidHashMap["Test:17"] = {rtwname: "<Root>/Scope1"};
	this.rtwnameHashMap["<S1>/Output"] = {sid: "Test:9:1"};
	this.sidHashMap["Test:9:1"] = {rtwname: "<S1>/Output"};
	this.rtwnameHashMap["<S1>/White Noise"] = {sid: "Test:9:2"};
	this.sidHashMap["Test:9:2"] = {rtwname: "<S1>/White Noise"};
	this.rtwnameHashMap["<S1>/y"] = {sid: "Test:9:3"};
	this.sidHashMap["Test:9:3"] = {rtwname: "<S1>/y"};
	this.rtwnameHashMap["<S2>/Output"] = {sid: "Test:16:1"};
	this.sidHashMap["Test:16:1"] = {rtwname: "<S2>/Output"};
	this.rtwnameHashMap["<S2>/White Noise"] = {sid: "Test:16:2"};
	this.sidHashMap["Test:16:2"] = {rtwname: "<S2>/White Noise"};
	this.rtwnameHashMap["<S2>/y"] = {sid: "Test:16:3"};
	this.sidHashMap["Test:16:3"] = {rtwname: "<S2>/y"};
	this.rtwnameHashMap["<S3>:2"] = {sid: "Test:6:2"};
	this.sidHashMap["Test:6:2"] = {rtwname: "<S3>:2"};
	this.rtwnameHashMap["<S3>:1"] = {sid: "Test:6:1"};
	this.sidHashMap["Test:6:1"] = {rtwname: "<S3>:1"};
	this.rtwnameHashMap["<S3>:5"] = {sid: "Test:6:5"};
	this.sidHashMap["Test:6:5"] = {rtwname: "<S3>:5"};
	this.rtwnameHashMap["<S3>:3"] = {sid: "Test:6:3"};
	this.sidHashMap["Test:6:3"] = {rtwname: "<S3>:3"};
	this.rtwnameHashMap["<S3>:4"] = {sid: "Test:6:4"};
	this.sidHashMap["Test:6:4"] = {rtwname: "<S3>:4"};
	this.rtwnameHashMap["<S4>:2"] = {sid: "Test:18:2"};
	this.sidHashMap["Test:18:2"] = {rtwname: "<S4>:2"};
	this.rtwnameHashMap["<S4>:1"] = {sid: "Test:18:1"};
	this.sidHashMap["Test:18:1"] = {rtwname: "<S4>:1"};
	this.rtwnameHashMap["<S4>:5"] = {sid: "Test:18:5"};
	this.sidHashMap["Test:18:5"] = {rtwname: "<S4>:5"};
	this.rtwnameHashMap["<S4>:3"] = {sid: "Test:18:3"};
	this.sidHashMap["Test:18:3"] = {rtwname: "<S4>:3"};
	this.rtwnameHashMap["<S4>:4"] = {sid: "Test:18:4"};
	this.sidHashMap["Test:18:4"] = {rtwname: "<S4>:4"};
	this.rtwnameHashMap["<S4>:9"] = {sid: "Test:18:9"};
	this.sidHashMap["Test:18:9"] = {rtwname: "<S4>:9"};
	this.rtwnameHashMap["<S4>:8"] = {sid: "Test:18:8"};
	this.sidHashMap["Test:18:8"] = {rtwname: "<S4>:8"};
	this.rtwnameHashMap["<S5>/In1"] = {sid: "Test:1:116"};
	this.sidHashMap["Test:1:116"] = {rtwname: "<S5>/In1"};
	this.rtwnameHashMap["<S5>/Data Type Conversion"] = {sid: "Test:1:114"};
	this.sidHashMap["Test:1:114"] = {rtwname: "<S5>/Data Type Conversion"};
	this.rtwnameHashMap["<S5>/Digital Output"] = {sid: "Test:1:214"};
	this.sidHashMap["Test:1:214"] = {rtwname: "<S5>/Digital Output"};
	this.rtwnameHashMap["<S6>/In1"] = {sid: "Test:15:116"};
	this.sidHashMap["Test:15:116"] = {rtwname: "<S6>/In1"};
	this.rtwnameHashMap["<S6>/Data Type Conversion"] = {sid: "Test:15:114"};
	this.sidHashMap["Test:15:114"] = {rtwname: "<S6>/Data Type Conversion"};
	this.rtwnameHashMap["<S6>/PWM"] = {sid: "Test:15:215"};
	this.sidHashMap["Test:15:215"] = {rtwname: "<S6>/PWM"};
	this.getSID = function(rtwname) { return this.rtwnameHashMap[rtwname];}
	this.getRtwname = function(sid) { return this.sidHashMap[sid];}
}
RTW_rtwnameSIDMap.instance = new RTW_rtwnameSIDMap();
