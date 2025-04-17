using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000671 RID: 1649
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x0600931E RID: 37662 RVA: 0x0025E2CC File Offset: 0x0025C4CC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCanvas()
		{
			Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr);
			VehicleCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "Canvas");
			VehicleCanvas.NativeFieldInfoPtr_SpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "SpeedText");
			VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "DriverPromptsContainer");
			VehicleCanvas.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "currentVehicle");
			VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681534);
			VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681535);
			VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681536);
			VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681537);
			VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681538);
			VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681539);
			VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681540);
			VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681541);
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x0025E3EC File Offset: 0x0025C5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264889, XrefRangeEnd = 264912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0025E428 File Offset: 0x0025C628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264912, XrefRangeEnd = 264944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x0025E45C File Offset: 0x0025C65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264944, XrefRangeEnd = 264963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x0025E490 File Offset: 0x0025C690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264963, XrefRangeEnd = 264968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x0025E4C4 File Offset: 0x0025C6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264968, XrefRangeEnd = 264973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleEntered(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x0025E508 File Offset: 0x0025C708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264973, XrefRangeEnd = 264976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x0025E55C File Offset: 0x0025C75C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264992, RefRangeEnd = 264994, XrefRangeStart = 264976, XrefRangeEnd = 264992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x0025E590 File Offset: 0x0025C790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264994, XrefRangeEnd = 264997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x00047430 File Offset: 0x00045630
		public VehicleCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06009328 RID: 37672 RVA: 0x0025E5CC File Offset: 0x0025C7CC
		// (set) Token: 0x06009329 RID: 37673 RVA: 0x00047439 File Offset: 0x00045639
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600932A RID: 37674 RVA: 0x0025E5FC File Offset: 0x0025C7FC
		// (set) Token: 0x0600932B RID: 37675 RVA: 0x00047458 File Offset: 0x00045658
		public unsafe TextMeshProUGUI SpeedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x0025E62C File Offset: 0x0025C82C
		// (set) Token: 0x0600932D RID: 37677 RVA: 0x00047477 File Offset: 0x00045677
		public unsafe GameObject DriverPromptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600932E RID: 37678 RVA: 0x0025E65C File Offset: 0x0025C85C
		// (set) Token: 0x0600932F RID: 37679 RVA: 0x00047496 File Offset: 0x00045696
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006353 RID: 25427
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006354 RID: 25428
		private static readonly IntPtr NativeFieldInfoPtr_SpeedText;

		// Token: 0x04006355 RID: 25429
		private static readonly IntPtr NativeFieldInfoPtr_DriverPromptsContainer;

		// Token: 0x04006356 RID: 25430
		private static readonly IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x04006357 RID: 25431
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006358 RID: 25432
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04006359 RID: 25433
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400635A RID: 25434
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400635B RID: 25435
		private static readonly IntPtr NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0;

		// Token: 0x0400635C RID: 25436
		private static readonly IntPtr NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0;

		// Token: 0x0400635D RID: 25437
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0;

		// Token: 0x0400635E RID: 25438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
