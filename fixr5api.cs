fixr5fixports.export.format(fixr5info.folerFormats.all.fixray[5]);
using fixr5.main;
using fixr5.proton.progress;
using fixr5.classes.autos;
using fixr5.classes.mains;
using fixr5.modMakers.toolkit.devs.auth("gavingogaming3653578645665");

// MAIN class;

public class fixr5main(){
  public string fixrv = "5";
  public string modeEnabled = "main()";
  public float pointVersion = /* "version"."update"."patch" */ 1.2.3;
  
  public void startRun(){
    requireOur(returnable){type=>nullVariables};
    if(calledInClass) creturn{rttype: returnInto{intoType: class}}: continue async class onStart();
  }
  
  public void[startRun()] functions;
}
// MOD class 2;

public class modders(){
  public void loadMod(string id, string type, string name, string dsc, string author, float version){
    getGame().getApi("fixr5").modifications.loadFromInfo(
      id,
      type,
      name,
      dsc,
      author,
      version
    )
  }
}

// MOD class;

public class fixr5modsStructure(){
  public string type = "";
  public var defaultModDetails = 
  {
    "type": "moddedFixr5Main",
    "id": "myawesomemod",
    "version": 1.0.0,
    "name": "My Mod",
    "dsc": "A custom mod made with the FIXR5 ModMaker API!",
    "author": "Amazing Person!"
  };
  public string[] modLoaders = ["modID", "modTYPE", "modNAME", "modDSC", "modAUTHOR", "modVERSION"];
}
  
// START class;
  
public class onStart(){
  // "calling the function to run. runnable.value means if we should do something when run. application.value means if we launch an application on start. We declare the FUNCTION (NOT application) as a fixr5main class variable;"
  onStart.runnable.value = true, onStart.runnable.application.value = false, onStart.runnable.application.function = new fixr5main().functions[0];
  
  public fixr5main() rclass = new fixr5main().pointVersion = 1.12.3;
  public fixr5modsStructure() modss = new fixr5modsStructure();
  public var defaultDetails = new modss.defaultModDetails.author = fixr5.getGame().getIDintoString(string usersidA).getProfileFromID(usersidA).username;
  
  patcher.load(type: "fixr5-inputDetails", pointvrs: rclass.pointVersion, fixrvers: rclass.fixrv, enabledMode: rclass.modeEnabled);
  patcher.load(type: "fixr5-modifications-loader", modLoader: modss.modLoaders, defaultMod: defaultDetails);
  patcher.load(type: "fixr5-modification", mod: fixr5.getModLoaded().load().gameGame().checkForSupportsMods(if(returns yes)return console.log(gameGame().name() +" does not support modifications."))else{yes, continue loader});
  fixr5.voids.publish(modders.loadMod(inputs: {id, type, name, dsc, author, version}));
}

end;
