using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F8 RID: 1528
	[Serializable]
	public class FaceLayer : AvatarLayer
	{
		// Token: 0x060086D1 RID: 34513 RVA: 0x000401EA File Offset: 0x0003E3EA
		// Note: this type is marked as 'beforefieldinit'.
		static FaceLayer()
		{
			Il2CppClassPointerStore<FaceLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "FaceLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr);
			FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr, 100680128);
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x0023A110 File Offset: 0x00238310
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x00040223 File Offset: 0x0003E423
		public FaceLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005BC0 RID: 23488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
