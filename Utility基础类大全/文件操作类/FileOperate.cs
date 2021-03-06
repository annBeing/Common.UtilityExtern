/// <summary>
/// 获取dt以后修改的文件列表
/// </summary>
/// <param name="dt">时间</param>
/// <param name="path">目标文件路径</param>
///<param name="searchPattern"></param>
/// <returns></returns>
public static string[] GetNewFileList(DateTime dt, string path,string searchPattern)
{
    var dicInfo = new DirectoryInfo(path);
    var filesInfo = dicInfo.GetFiles(searchPattern, 
            SearchOption.AllDirectories).Where(p => p.LastWriteTime > dt)
            .Select(p => p.FullName);
    if (filesInfo == null)
        return null;
    return  filesInfo.ToArray(); ;
}
