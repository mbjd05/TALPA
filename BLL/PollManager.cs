﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	internal class PollManager
	{
		private void Splitactivitiess(Poll poll)
		{
			if (poll.activity_id.Count == 3)
			{
				poll.ActivityVotes1 = poll.activity_id[0];
				poll.ActivityVotes2 = poll.activity_id[1];
				poll.ActivityVotes3 = poll.activity_id[2];
			}
		}
		public void ActivityVoted(int VotedActivity, Poll poll)
		{
			switch (VotedActivity)
			{
				case 1:
					poll.ActivityVotes1++;
					break;
				case 2:
					poll.ActivityVotes2++;
					break;
				case 3:
					poll.ActivityVotes3++;
					break;
			}
		}

		public void DeadlineCheck(Poll poll)
		{
			if (DateTime.Now >= poll.Deadline)
			{
				DecideWinner(poll);
				GivePointsToWinner();
			}
		}

		private void DecideWinner(Poll poll)
		{
			if (poll.ActivityVotes1 > poll.ActivityVotes2 && poll.ActivityVotes1 > poll.ActivityVotes3)
			{
				// verwijst naar de activity die gewonnen heeft en zet won op true
				poll.Won = true;
			}

			else if (poll.ActivityVotes2 > poll.ActivityVotes1 && poll.ActivityVotes2 > poll.ActivityVotes3)
			{
				// verwijst naar de activity die gewonnen heeft en zet won op true
				poll.Won = true;
			}

			else if (poll.ActivityVotes3 > poll.ActivityVotes1 && poll.ActivityVotes3 > poll.ActivityVotes2)
			{
				// verwijst naar de activity die gewonnen heeft en zet won op true
				poll.Won = true;
			}

			else
			{
				TieBreaker(poll);
			}
		}

		private void TieBreaker(Poll poll)
		{
			if (poll.ActivityVotes1 == poll.ActivityVotes2 && poll.ActivityVotes1 == poll.ActivityVotes3)
			{
				GetTripleRandom(poll);
				if (poll.TieBreakerNumber == 0)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}

				else if (poll.TieBreakerNumber == 1)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}

				else if (poll.TieBreakerNumber == 2)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}
			}

			else if (poll.ActivityVotes1 == poll.ActivityVotes2)
			{
				GetDoubleRandom(poll);
				if (poll.TieBreakerNumber == 0)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}

				else if (poll.TieBreakerNumber == 1)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}
			}

			else if (poll.ActivityVotes1 == poll.ActivityVotes3)
			{
				GetDoubleRandom(poll);
				if (poll.TieBreakerNumber == 0)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}

				else if (poll.TieBreakerNumber == 1)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}
			}

			else if (poll.ActivityVotes2 == poll.ActivityVotes3)
			{
				GetDoubleRandom(poll);
				if (poll.TieBreakerNumber == 0)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}

				else if (poll.TieBreakerNumber == 1)
				{
					// verwijst naar de activity die gewonnen heeft en zet won op true
					poll.Won = true;
				}
			}
		}

		private void GetDoubleRandom(Poll poll)
		{
			Random rnd = new Random();
			poll.TieBreakerNumber = rnd.Next(1);
		}

		private void GetTripleRandom(Poll poll)
		{
			Random rnd = new Random();
			poll.TripleTieBreakerNumber = rnd.Next(2);
		}

		private void GivePointsToWinner()
		{

		}
	}
}