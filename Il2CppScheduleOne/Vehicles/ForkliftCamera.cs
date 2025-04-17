using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DD RID: 1245
	public class ForkliftCamera : VehicleCamera
	{
		// Token: 0x06006CED RID: 27885 RVA: 0x001E30F8 File Offset: 0x001E12F8
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftCamera()
		{
			Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr);
			ForkliftCamera.NativeFieldInfoPtr_forkCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkCamPos");
			ForkliftCamera.NativeFieldInfoPtr_guidanceLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "guidanceLight");
			ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkliftCamActive");
			ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677066);
			ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677067);
			ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677068);
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x001E31A0 File Offset: 0x001E13A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217484, XrefRangeEnd = 217486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x001E31DC File Offset: 0x001E13DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217486, XrefRangeEnd = 217500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x001E3218 File Offset: 0x001E1418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217500, XrefRangeEnd = 217501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x000338F5 File Offset: 0x00031AF5
		public ForkliftCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x001E3254 File Offset: 0x001E1454
		// (set) Token: 0x06006CF3 RID: 27891 RVA: 0x000338FE File Offset: 0x00031AFE
		public unsafe Transform forkCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x001E3284 File Offset: 0x001E1484
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x0003391D File Offset: 0x00031B1D
		public unsafe Light guidanceLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x001E32B4 File Offset: 0x001E14B4
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x0003393C File Offset: 0x00031B3C
		public unsafe bool forkliftCamActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive)) = value;
			}
		}

		// Token: 0x04004A76 RID: 19062
		private static readonly IntPtr NativeFieldInfoPtr_forkCamPos;

		// Token: 0x04004A77 RID: 19063
		private static readonly IntPtr NativeFieldInfoPtr_guidanceLight;

		// Token: 0x04004A78 RID: 19064
		private static readonly IntPtr NativeFieldInfoPtr_forkliftCamActive;

		// Token: 0x04004A79 RID: 19065
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004A7A RID: 19066
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004A7B RID: 19067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
