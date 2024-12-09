import heapq

def dijkstra_with_path(graph, start, end):
    # Инициализация
    distances = {node: float('inf') for node in graph}
    distances[start] = 0
    priority_queue = [(0, start)]
    previous_nodes = {node: None for node in graph}  # Храним предков для восстановления пути
    visited = set()
    
    while priority_queue:
        current_distance, current_node = heapq.heappop(priority_queue)
        
        if current_node in visited:
            continue
        visited.add(current_node)
        
        # Обновляем расстояния до соседей
        for neighbor, weight in graph[current_node].items():
            distance = current_distance + weight
            if distance < distances[neighbor]:
                distances[neighbor] = distance
                previous_nodes[neighbor] = current_node  # Запоминаем путь
                heapq.heappush(priority_queue, (distance, neighbor))
    
    # Восстанавливаем путь
    path = []
    current = end
    while current is not None:
        path.append(current)
        current = previous_nodes[current]
    path.reverse()
    
    # Если путь не найден
    if distances[end] == float('inf'):
        return None, float('inf')
    
    return path, distances[end]


def main():
    # Ввод графа
    print("Введите граф (в формате 'A B вес'). Введите пустую строку, чтобы завершить:")
    graph = {}
    while True:
        line = input()
        if not line.strip():
            break
        node1, node2, weight = line.split()
        weight = int(weight)
        
        # Добавляем ребро в обе стороны (неориентированный граф)
        if node1 not in graph:
            graph[node1] = {}
        if node2 not in graph:
            graph[node2] = {}
        graph[node1][node2] = weight
        graph[node2][node1] = weight
    
    # Ввод начальной и конечной точки
    start = input("Введите начальную вершину: ").strip()
    end = input("Введите конечную вершину: ").strip()
    
    # Проверяем, что такие вершины существуют в графе
    if start not in graph or end not in graph:
        print("Ошибка: одна или обе вершины отсутствуют в графе!")
        return
    
    # Поиск кратчайшего пути
    path, distance = dijkstra_with_path(graph, start, end)
    if path is None:
        print(f"Путь из {start} в {end} не существует!")
    else:
        print(f"Кратчайший путь из {start} в {end}: {' -> '.join(path)}")
        print(f"Общее расстояние: {distance}")


if __name__ == "__main__":
    main()
