using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002E RID: 46
	public class MeshMerger : MonoBehaviour
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0007A6C8 File Offset: 0x000788C8
		// Note: this type is marked as 'beforefieldinit'.
		static MeshMerger()
		{
			Il2CppClassPointerStore<MeshMerger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshMerger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshMerger>.NativeClassPtr);
			MeshMerger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshMerger>.NativeClassPtr, 100663609);
			MeshMerger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshMerger>.NativeClassPtr, 100663610);
			MeshMerger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshMerger>.NativeClassPtr, 100663611);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0007A734 File Offset: 0x00078934
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshMerger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0007A768 File Offset: 0x00078968
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshMerger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0007A79C File Offset: 0x0007899C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshMerger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshMerger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshMerger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003D23 File Offset: 0x00001F23
		public MeshMerger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
