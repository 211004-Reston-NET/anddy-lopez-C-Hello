W# This is a comment to add more information to your code
# echo Comment
echo Hello # <- This is an echo to display Hello
echo World Testing pls work #It worked

msg="Hello World"

echo $msg

echo What is your name?
read userInput
echo "Hello $userInput, Welcome to Programming!"

# Control Flow
# Types of loops
# For loop - They will repeat something a set number of times
for var in 1 2 3 4 5
do
	echo $var
	echo This variable currently holds: $var
done

for i in {1..10..1} #{starting number.. end number ..increment number}
do
	echo $i
done

# While loops - they will repeat something until the condtion isn't satisfied anymore
condition="true"

while [ "$condition" != "false" ]
do
	echo "Do you want to repeat? (true or false)"
	read condition
	echo "You typed: $condition"
done

# If loops

echo "What is 2 + 2?"
read input
if [ "$input" == "4" ]
then
	echo You are smart
fi


