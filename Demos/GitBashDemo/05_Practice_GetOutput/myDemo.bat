echo. |"Get My Output.exe">output.txt
IF findstr "Parameter" output.txt | "2"
echo %Errorlevel eql 0(
echo Parameter 2 exist) else ( 
echo %Parameter 2 doesn't exist)

