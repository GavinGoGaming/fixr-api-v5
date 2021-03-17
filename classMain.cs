fixr5fixports.export.format(fixr5info.folerFormats.all.fixray[5]);
using fixr5.main;
using fixr5.proton.progress;
using fixr5.classes.autos;
using fixr5.classes.mains;

public class fixr5main(){
  public string fixrv = "5";
  public strinf modeEnabled = "main()";
  public float pointVersion = /* "version"."update"."patch" */ 1.2.3;
  
  public void startRun(){
    requireOur(returnable){type=>nullVariables};
    if(calledInClass) creturn{rttype: returnInto{intoType: class}}: continue async class onStart();
  }
  
  public void[startRun()] functions;
}

public class onStart(){
  // "calling the function to run. runnable.value means if we should do something when run. application.value means if we launch an application on start. We declare the FUNCTION (NOT application) as a fixr5main class variable;"
  onStart.runnable.value = true, onStart.runnable.application.value = false, onStart.runnable.application.function = new fixr5main().functions[0];
}
