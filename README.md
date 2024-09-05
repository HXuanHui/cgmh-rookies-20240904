## 參考資料
 - [`教學課程：使用 ASP.NET Core 建立 Web API`](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)
## 概觀

本練習會建立以下 API：

| API | 描述 | 要求本文 | 回應本文 |
| --- | --- | --- | --- |
| `GET /api/todoitems` | 取得所有待辦事項 | 無 | 待辦事項的陣列 |
| `GET /api/todoitems/{id}` | 依識別碼取得項目 | 無 | 待辦事項 |
| `POST /api/todoitems` | 新增記錄 | 待辦事項 | 待辦事項 |
| `PUT /api/todoitems/{id}` | 更新現有的項目 | 待辦事項 | 無 |
| `DELETE /api/todoitems/{id}` | 刪除項目 | 無 | 無 |

下圖顯示應用程式的設計。

![image](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-web-api/_static/architecture.png?view=aspnetcore-8.0])
### 測試 PostTodoItem

- 按 Ctrl+F5 執行應用程式。
- 在 Swagger 瀏覽器視窗中，選取 [POST /api/TodoItems]，然後選取 [試用]。
- 在 [要求本文] 輸入視窗中，更新 JSON。 例如，
    
    ```
    {
      "name": "walk dog",
      "isComplete": true
    }
    
    ```
    
- 選取 [執行]
    
    ![image](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-web-api/_static/7/post.png?view=aspnetcore-8.0)
    
    

### 測試位置標頭 URI

在上述 POST 中，Swagger UI 會顯示 [回應] 標頭底下的[位置標頭](https://developer.mozilla.org/docs/Web/HTTP/Headers/Location)。 例如： `location: https://localhost:7260/api/TodoItems/1` 。 位置標頭會顯示所建立資源的 URI。

若要測試位置標頭：

- 在 Swagger 瀏覽器視窗中，選取 [GET /api/TodoItems/{id}]，然後選取 [試用]。
- 在 `id` 輸入方塊中輸入 `1`，然後選取 [執行]。
    
    ![image](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-web-api/_static/7/get.png?view=aspnetcore-8.0)
    
### 測試 PutTodoItem 方法

此範例使用在每次應用程式啟動都必須初始化的記憶體內部資料庫。 資料庫中必須有項目，您才能進行 PUT 呼叫。 在發出 PUT 呼叫之前，呼叫 GET 以確保資料庫中有項目。

使用 Swagger UI，使用 PUT 按鈕來更新識別碼為 1 的 `TodoItem`，並將其名稱設定為 `"feed fish"`。 請注意，回應為 [`HTTP 204 No Content`](https://developer.mozilla.org/docs/Web/HTTP/Status/204)。
### 測試 DeleteTodoItem 方法

使用 Swagger UI 刪除識別碼為 1 的 `TodoItem`。 請注意，回應為 [`HTTP 204 No Content`](https://developer.mozilla.org/docs/Web/HTTP/Status/204)。
