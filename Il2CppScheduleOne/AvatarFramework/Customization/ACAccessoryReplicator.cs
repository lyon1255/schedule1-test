using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000619 RID: 1561
	public class ACAccessoryReplicator : ACAssetPathReplicator<Accessory>
	{
		// Token: 0x06008A2A RID: 35370 RVA: 0x000420CC File Offset: 0x000402CC
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessoryReplicator()
		{
			Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessoryReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr);
			ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr, 100680478);
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x00243C88 File Offset: 0x00241E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253981, XrefRangeEnd = 253984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessoryReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x00042105 File Offset: 0x00040305
		public ACAccessoryReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DC7 RID: 24007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
