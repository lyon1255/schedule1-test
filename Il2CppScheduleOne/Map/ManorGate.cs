using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077A RID: 1914
	public class ManorGate : Gate
	{
		// Token: 0x0600B562 RID: 46434 RVA: 0x002D18AC File Offset: 0x002CFAAC
		// Note: this type is marked as 'beforefieldinit'.
		static ManorGate()
		{
			Il2CppClassPointerStore<ManorGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ManorGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManorGate>.NativeClassPtr);
			ManorGate.NativeFieldInfoPtr_IntercomInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomInt");
			ManorGate.NativeFieldInfoPtr_IntercomLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomLight");
			ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_intercomActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "intercomActive");
			ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685592);
			ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685593);
			ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685594);
			ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685595);
			ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685596);
			ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685597);
			ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685598);
			ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685599);
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x002D1A08 File Offset: 0x002CFC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309924, XrefRangeEnd = 309932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x002D1A44 File Offset: 0x002CFC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309932, XrefRangeEnd = 309936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x002D1A78 File Offset: 0x002CFC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309936, XrefRangeEnd = 309938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntercomBuzzed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x002D1AAC File Offset: 0x002CFCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309942, RefRangeEnd = 309943, XrefRangeStart = 309938, XrefRangeEnd = 309942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnterable(bool enterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enterable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x002D1AEC File Offset: 0x002CFCEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309945, RefRangeEnd = 309948, XrefRangeStart = 309943, XrefRangeEnd = 309945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x002D1B20 File Offset: 0x002CFD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309948, XrefRangeEnd = 309950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntercomActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x002D1B60 File Offset: 0x002CFD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309950, XrefRangeEnd = 309952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x002D1B94 File Offset: 0x002CFD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManorGate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManorGate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x00059062 File Offset: 0x00057262
		public ManorGate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B56C RID: 46444 RVA: 0x002D1BD0 File Offset: 0x002CFDD0
		// (set) Token: 0x0600B56D RID: 46445 RVA: 0x0005906B File Offset: 0x0005726B
		public unsafe InteractableObject IntercomInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x002D1C00 File Offset: 0x002CFE00
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x0005908A File Offset: 0x0005728A
		public unsafe Light IntercomLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x002D1C30 File Offset: 0x002CFE30
		// (set) Token: 0x0600B571 RID: 46449 RVA: 0x000590A9 File Offset: 0x000572A9
		public unsafe VehicleDetector ExteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x002D1C60 File Offset: 0x002CFE60
		// (set) Token: 0x0600B573 RID: 46451 RVA: 0x000590C8 File Offset: 0x000572C8
		public unsafe PlayerDetector ExteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600B574 RID: 46452 RVA: 0x002D1C90 File Offset: 0x002CFE90
		// (set) Token: 0x0600B575 RID: 46453 RVA: 0x000590E7 File Offset: 0x000572E7
		public unsafe VehicleDetector InteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600B576 RID: 46454 RVA: 0x002D1CC0 File Offset: 0x002CFEC0
		// (set) Token: 0x0600B577 RID: 46455 RVA: 0x00059106 File Offset: 0x00057306
		public unsafe PlayerDetector InteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600B578 RID: 46456 RVA: 0x002D1CF0 File Offset: 0x002CFEF0
		// (set) Token: 0x0600B579 RID: 46457 RVA: 0x00059125 File Offset: 0x00057325
		public unsafe bool intercomActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive)) = value;
			}
		}

		// Token: 0x04007A3C RID: 31292
		private static readonly IntPtr NativeFieldInfoPtr_IntercomInt;

		// Token: 0x04007A3D RID: 31293
		private static readonly IntPtr NativeFieldInfoPtr_IntercomLight;

		// Token: 0x04007A3E RID: 31294
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorVehicleDetector;

		// Token: 0x04007A3F RID: 31295
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorPlayerDetector;

		// Token: 0x04007A40 RID: 31296
		private static readonly IntPtr NativeFieldInfoPtr_InteriorVehicleDetector;

		// Token: 0x04007A41 RID: 31297
		private static readonly IntPtr NativeFieldInfoPtr_InteriorPlayerDetector;

		// Token: 0x04007A42 RID: 31298
		private static readonly IntPtr NativeFieldInfoPtr_intercomActive;

		// Token: 0x04007A43 RID: 31299
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007A44 RID: 31300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDetection_Private_Void_0;

		// Token: 0x04007A45 RID: 31301
		private static readonly IntPtr NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0;

		// Token: 0x04007A46 RID: 31302
		private static readonly IntPtr NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0;

		// Token: 0x04007A47 RID: 31303
		private static readonly IntPtr NativeMethodInfoPtr_ActivateIntercom_Public_Void_0;

		// Token: 0x04007A48 RID: 31304
		private static readonly IntPtr NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0;

		// Token: 0x04007A49 RID: 31305
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIntercom_Private_Void_0;

		// Token: 0x04007A4A RID: 31306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
