using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052D RID: 1325
	public class CameraOverrider : MonoBehaviour
	{
		// Token: 0x0600764A RID: 30282 RVA: 0x00202A68 File Offset: 0x00200C68
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOverrider()
		{
			Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CameraOverrider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr);
			CameraOverrider.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, "FOV");
			CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678195);
			CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678196);
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00202AD4 File Offset: 0x00200CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230609, XrefRangeEnd = 230623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00202B08 File Offset: 0x00200D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230623, XrefRangeEnd = 230624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOverrider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x000380E0 File Offset: 0x000362E0
		public CameraOverrider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600764E RID: 30286 RVA: 0x00202B44 File Offset: 0x00200D44
		// (set) Token: 0x0600764F RID: 30287 RVA: 0x000380E9 File Offset: 0x000362E9
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x040050D0 RID: 20688
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x040050D1 RID: 20689
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040050D2 RID: 20690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
