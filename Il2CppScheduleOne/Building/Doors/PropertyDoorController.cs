using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004C5 RID: 1221
	public class PropertyDoorController : DoorController
	{
		// Token: 0x06006ADC RID: 27356 RVA: 0x001DCD60 File Offset: 0x001DAF60
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDoorController()
		{
			Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "PropertyDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr);
			PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "WANTED_PLAYER_CLOSE_DISTANCE");
			PropertyDoorController.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "Property");
			PropertyDoorController.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "IsUnlocked");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676842);
			PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676843);
			PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676844);
			PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676845);
			PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676846);
			PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676847);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676848);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676849);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676850);
			PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676851);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x001DCEBC File Offset: 0x001DB0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215271, XrefRangeEnd = 215287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x001DCEF8 File Offset: 0x001DB0F8
		[CallerCount(0)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x001DCF2C File Offset: 0x001DB12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215287, XrefRangeEnd = 215297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x001DCF60 File Offset: 0x001DB160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215297, XrefRangeEnd = 215323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x001DCFD0 File Offset: 0x001DB1D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215357, RefRangeEnd = 215359, XrefRangeStart = 215323, XrefRangeEnd = 215357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestWantedPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x001DD010 File Offset: 0x001DB210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215359, XrefRangeEnd = 215360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x001DD04C File Offset: 0x001DB24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215360, XrefRangeEnd = 215361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x001DD088 File Offset: 0x001DB288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215361, XrefRangeEnd = 215362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x001DD0C4 File Offset: 0x001DB2C4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x001DD100 File Offset: 0x001DB300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215362, XrefRangeEnd = 215377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x0003286C File Offset: 0x00030A6C
		public PropertyDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x001DD13C File Offset: 0x001DB33C
		// (set) Token: 0x06006AE9 RID: 27369 RVA: 0x00032875 File Offset: 0x00030A75
		public unsafe static float WANTED_PLAYER_CLOSE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06006AEA RID: 27370 RVA: 0x001DD158 File Offset: 0x001DB358
		// (set) Token: 0x06006AEB RID: 27371 RVA: 0x00032883 File Offset: 0x00030A83
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06006AEC RID: 27372 RVA: 0x001DD188 File Offset: 0x001DB388
		// (set) Token: 0x06006AED RID: 27373 RVA: 0x000328A2 File Offset: 0x00030AA2
		public unsafe bool IsUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked)) = value;
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06006AEE RID: 27374 RVA: 0x001DD1B0 File Offset: 0x001DB3B0
		// (set) Token: 0x06006AEF RID: 27375 RVA: 0x000328BD File Offset: 0x00030ABD
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06006AF0 RID: 27376 RVA: 0x001DD1D8 File Offset: 0x001DB3D8
		// (set) Token: 0x06006AF1 RID: 27377 RVA: 0x000328D8 File Offset: 0x00030AD8
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004921 RID: 18721
		private static readonly IntPtr NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE;

		// Token: 0x04004922 RID: 18722
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004923 RID: 18723
		private static readonly IntPtr NativeFieldInfoPtr_IsUnlocked;

		// Token: 0x04004924 RID: 18724
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004925 RID: 18725
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004926 RID: 18726
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004927 RID: 18727
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x04004928 RID: 18728
		private static readonly IntPtr NativeMethodInfoPtr_CheckClose_Private_Void_0;

		// Token: 0x04004929 RID: 18729
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0;

		// Token: 0x0400492A RID: 18730
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0;

		// Token: 0x0400492B RID: 18731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400492C RID: 18732
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400492D RID: 18733
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400492E RID: 18734
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400492F RID: 18735
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
