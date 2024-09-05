//Interface para comentário de filme
public interface IComment
{
	void SetComment(int MovieId, int UserId, string comment);
	string[] GetComments(int MovieId);
	string[] GetCommentsByUserId(int MovieId, int UserId);
}