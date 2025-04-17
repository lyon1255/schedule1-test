using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BA RID: 186
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x0009D7A8 File Offset: 0x0009B9A8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraToggleBeamVisibility()
		{
			Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "CameraToggleBeamVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr);
			CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, "m_KeyCode");
			CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100665018);
			CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100665019);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0009D814 File Offset: 0x0009BA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85473, XrefRangeEnd = 85481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0009D848 File Offset: 0x0009BA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85481, XrefRangeEnd = 85482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraToggleBeamVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00008BA0 File Offset: 0x00006DA0
		public CameraToggleBeamVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0009D884 File Offset: 0x0009BA84
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public unsafe KeyCode m_KeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode)) = value;
			}
		}

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyCode;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
