namespace Exercises.Classes
{
    public class Television
    {

        //private bool isOn;
        //public bool IsOn
        //{
        //    get
        //    {
        //        return isOn;
        //    }
        //}

        public bool IsOn { get; private set; }

        //private int defaultChannel = 3;
        //private int currentChannel;
        //public int CurrentChannel
        //{
        //    get
        //    {
        //        if (IsOn == true)
        //        {
        //            return currentChannel;
        //        }
        //        else
        //        {
        //            return defaultChannel;
        //        }
        //    }
        //}

        public int CurrentChannel { get; private set; } = 3;

        //private int defaultVolume = 2;
        //private int currentVolume;
        //public int CurrentVolume
        //{
        //    get
        //    {
        //        if (IsOn == true)
        //        {
        //            return currentVolume;
        //        }
        //        else
        //        {
        //            return defaultVolume;
        //        }
        //    }
        //}

        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
        public void ChangeChannel(int newChannel)
        {
            if ((IsOn == true) && ((newChannel >= 3) && (newChannel <= 18)))
            {
                CurrentChannel = newChannel;
            }
            //else
            //{
            //    IsOn = false;
            //}
        }
        public void ChannelUp()
        {
            if ((IsOn == true) && (CurrentChannel < 18))
            {
                CurrentChannel++;
            }
            else if ((IsOn == true) && (CurrentChannel == 18))
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelDown()
        {
            if ((IsOn == true) && (CurrentChannel > 3))
            {
                CurrentChannel--;
            }
            else if ((IsOn == true) && (CurrentChannel == 3))
            {
                CurrentChannel = 18;
            }
        }
        public void RaiseVolume()
        {
            if ((IsOn == true) && (CurrentVolume < 10))
            {
                CurrentVolume++;
            }
            else if ((IsOn == true) && (CurrentVolume == 10))
            {
                CurrentVolume = 10;
            }
        }
        public void LowerVolume()
        {
            if ((IsOn == true) && (CurrentVolume > 0))
            {
                CurrentVolume--;
            }
            else if ((IsOn == true) && (CurrentVolume == 0))
            {
                CurrentVolume = 0;
            }
        }

    }
}
