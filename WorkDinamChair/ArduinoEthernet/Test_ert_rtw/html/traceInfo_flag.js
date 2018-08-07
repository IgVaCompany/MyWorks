function TraceInfoFlag() {
    this.traceFlag = new Array();
    this.traceFlag["Test.c:104c35"]=1;
    this.traceFlag["Test.c:142c16"]=1;
    this.traceFlag["Test.c:143c18"]=1;
    this.traceFlag["Test.c:161c37"]=1;
    this.traceFlag["Test.c:161c57"]=1;
    this.traceFlag["Test.c:215c16"]=1;
    this.traceFlag["Test.c:216c18"]=1;
}
top.TraceInfoFlag.instance = new TraceInfoFlag();
