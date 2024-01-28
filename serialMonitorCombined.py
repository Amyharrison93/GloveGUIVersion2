import serial
import socket
import threading

# Set up serial port
ser = serial.Serial('COM2')

# Set up socket
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server_address = ('localhost', 5000)  # replace 'localhost' with your IP
sock.bind(server_address)

# Set up lock for combined log file
lock = threading.Lock()

# Function to listen to serial port and write to logs
def serial_listen():
    with open('serial_log.txt', 'w') as f, open('combined_log.txt', 'a') as cf:
        while True:
            data = ser.readline()
            f.write(data)
            with lock:
                cf.write(f'SERIAL: {data}')

# Function to listen to socket and write to logs
def socket_listen():
    sock.listen(1)
    conn, client_address = sock.accept()
    with open('socket_log.txt', 'w') as f, open('combined_log.txt', 'a') as cf:
        while True:
            data = conn.recv(16)
            f.write(data)
            with lock:
                cf.write(f'SOCKET: {data}')

# Start threads
threading.Thread(target=serial_listen).start()
threading.Thread(target=socket_listen).start()
