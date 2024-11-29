import os

# Get the current directory
script_dir = os.path.dirname(os.path.abspath(__file__))
os.chdir(script_dir)

file_path = "input.txt"
input_value = ""
input_split = ""
array_of_numbers_to_add = []
total_result = 0

# Get the input
with open(file_path, 'r') as file:
    input_value = file.read()

input_split = input_value.splitlines()

print(input_split)

for line in input_split:
    number_array = []
    for letter in line:
        try:
            number_array.append(int(letter))
            print(int(letter))
        except:
            pass
    print(number_array)
    line_result = number_array[0] * 10 + number_array[len(number_array)-1]
    total_result += line_result

print(total_result)