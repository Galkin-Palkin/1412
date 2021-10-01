def decToBin(num):
    res = ''

    while num != 0:
        res += chr(48 + num % 2);
        num //= 2

    return res[::-1]

def decToHex(num):

    res = ''

    while num != 0:
        res += chr(48 + (num % 16) + (num % 16 > 9) * 7)
        num //= 16

    return res[::-1]

def decToOct(num):
    res = ''

    while num != 0:
        res += chr(48 + num % 8);
        num //= 8

    return res[::-1]


def menu_logic():
    print("1.Перевод 10СИ -> 2СИ")
    print("2.Перевод 10СИ -> 16СИ")
    print("3.Перевод 10СИ -> 8СИ")
    action = int(input())
    num = int(input())
    if action == 1:
        #print("dec2bin_op")
        num = decToBin(num)
    elif action == 2:
        #print("dec2hex_op")
        num = decToHex(num)
    elif action == 3:
        #print("dec2oct_op")
        num = decToOct(num)
    print(num)


def check_brackets():
    queue = []
    print("Введите строку с формулой:")
    str = input()
    queue.append(str[0])
    i = 1
    while i < len(str):
        if str[i] == "(":
            queue.append(str[i])
            i += 1
            continue
        if str[i] == ")" and queue[len(queue) - 1] == "(":
            del queue[len(queue) - 1]
            i += 1
            continue
    if len(queue):
        print("НЕТ")
    else:
        print("ДА")


def main():
    menu_logic()

if __name__ == "__main__":
    main()
