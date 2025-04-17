using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061B RID: 1563
	public class ACAvatarLayerReplicator : ACAssetPathReplicator<AvatarLayer>
	{
		// Token: 0x06008A34 RID: 35380 RVA: 0x00042136 File Offset: 0x00040336
		// Note: this type is marked as 'beforefieldinit'.
		static ACAvatarLayerReplicator()
		{
			Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAvatarLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr);
			ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr, 100680482);
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x00243E78 File Offset: 0x00242078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253996, XrefRangeEnd = 253999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAvatarLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x0004216F File Offset: 0x0004036F
		public ACAvatarLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DCC RID: 24012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
