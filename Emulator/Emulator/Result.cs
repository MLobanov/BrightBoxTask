using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Result
/// </summary>
public class Result
{
    /// <summary>
    /// Данные для сериализации
    /// </summary>
    public object Data;

    /// <summary>
    /// Необходима авторизация
    /// </summary>
    public bool NeedAuth;

    /// <summary>
    /// Сообщение об ошибке
    /// </summary>
    public string ErrorMessage;
    
    public Result()
    {
    }

}