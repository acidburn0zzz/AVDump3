using System;

namespace AVDump3Lib.Processing.BlockConsumers.Ogg.BitStreams {
    public class CeltOGGBitStream : AudioOGGBitStream {
		public override string CodecName { get { return "Celt"; } }
		public override string CodecVersion { get; protected set; }

		public CeltOGGBitStream()
			: base(true) {

		}


        public override void ProcessPage(OggPage page) {
			base.ProcessPage(page);

			var sampleIndex = BitConverter.ToInt64(page.GranulePosition, 0);
			if(SampleCount < (int)sampleIndex) SampleCount = (int)sampleIndex;
		}
	}
}