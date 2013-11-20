DotNetOpenAuth
==============

This fork is the last known version of DotNetOpenAuth that compiles for NET 4.0 with extra fix for signing key validation


Build Environment setup
=======================

Create a key pair container  
sn -i private-build-key.pfx PrivateDotNetOpenAuth

Register our public key for signing  
sn -Vr *,f68c4adc7f7ba8c9

Run from command line from root of DNOA (not src)  
msbuild /t:Nightly /p:configuration=Release /p:KeyPairContainer=PrivateDotNetOpenAuth,PublicKeyFile="C:\Path\To\private-build-key.pub"

Private build setup of DNOA from scratch 
========================================

Note this is not needed for this fork but if in future you need to do this from the upstream DNOA repo follow the instructions below

sn -k private-build-key.pfx  
 sn -i private-build-key.pfx PrivateDotNetOpenAuth  
 sn -p private-build-key.pfx private-build-key.pub 
 sn -q -t private-build-key.pub   # to print the public key token that you just generated to the console  
 sn -Vr *,<YourPublicKeyTokenHere>  
 sn -tp private-build-key.pub  #to print entire public key  

search for text  
0024000004800000940000000602000000240000525341310004000001000100AD093C3765257C89A7010E853F2C7C741FF92FA8ACE06D7B8254702CAD5CF99104447F63AB05F8BB6F51CE0D81C8C93D2FCE8C20AAFF7042E721CBA16EAAE98778611DED11C0ABC8900DC5667F99B50A9DADEC24DBD8F2C91E3E8AD300EF64F1B4B9536CEB16FB440AF939F57624A9B486F867807C649AE4830EAB88C6C03998

and replace with your actual long version of the public key  
to ensure all internals all still remain visible

also update DotNetOpenAuth.props at set your short public key token to so it replaces the official one  
<PublicKeyToken>f68c4adc7f7ba8c9</PublicKeyToken> 


