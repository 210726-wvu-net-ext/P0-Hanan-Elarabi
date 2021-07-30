n=1
while (( $n <= 20 ))
do
if [ $(( n%3 )) -eq 0 ] && [ $(( n%5 )) -eq 0 ]
then
echo "$n- FizzBuzz"
elif [ $(( n%3 )) -eq 0 ]
then
echo "$n- Fizz"
elif [ $(( n%5 )) -eq 0 ]
then
echo "$n- Buzz"
fi
(( n++ ))
done