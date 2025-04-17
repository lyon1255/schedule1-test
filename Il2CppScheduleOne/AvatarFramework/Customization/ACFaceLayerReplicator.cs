using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061D RID: 1565
	public class ACFaceLayerReplicator : ACAssetPathReplicator<FaceLayer>
	{
		// Token: 0x06008A3D RID: 35389 RVA: 0x000421A0 File Offset: 0x000403A0
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerReplicator()
		{
			Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr);
			ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr, 100680485);
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x00243FDC File Offset: 0x002421DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254009, XrefRangeEnd = 254012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x000421D9 File Offset: 0x000403D9
		public ACFaceLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DD0 RID: 24016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
