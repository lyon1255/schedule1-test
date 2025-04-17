using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BA RID: 1466
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x06008090 RID: 32912 RVA: 0x00225AC8 File Offset: 0x00223CC8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_TrashGrabber()
		{
			Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_TrashGrabber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr);
			Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<Instance>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSpacing");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Min");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Max");
			Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "GrabAnim");
			Equippable_TrashGrabber.NativeFieldInfoPtr_Bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "Bin");
			Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "BinRaisedPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSound");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropTime");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropForce");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropOffset");
			Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "onPickup");
			Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<currentDropTime>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<timeSinceLastDrop>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "trashGrabberInstance");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinScale");
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679429);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679430);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679431);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679432);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679433);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679434);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679435);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679436);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679437);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679438);
			Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679439);
			Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679440);
			Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679441);
			Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679442);
			Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679443);
			Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679444);
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00225DA0 File Offset: 0x00223FA0
		// (set) Token: 0x06008092 RID: 32914 RVA: 0x00225DD4 File Offset: 0x00223FD4
		public unsafe static Equippable_TrashGrabber Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244332, XrefRangeEnd = 244334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244334, XrefRangeEnd = 244338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00225E0C File Offset: 0x0022400C
		public unsafe static bool IsEquipped
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 244344, RefRangeEnd = 244346, XrefRangeStart = 244338, XrefRangeEnd = 244344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x06008094 RID: 32916 RVA: 0x00225E3C File Offset: 0x0022403C
		// (set) Token: 0x06008095 RID: 32917 RVA: 0x00225E78 File Offset: 0x00224078
		public unsafe float currentDropTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x06008096 RID: 32918 RVA: 0x00225EB8 File Offset: 0x002240B8
		// (set) Token: 0x06008097 RID: 32919 RVA: 0x00225EF4 File Offset: 0x002240F4
		public unsafe float timeSinceLastDrop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00225F34 File Offset: 0x00224134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244346, XrefRangeEnd = 244381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x00225F84 File Offset: 0x00224184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244381, XrefRangeEnd = 244405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x00225FC0 File Offset: 0x002241C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244405, XrefRangeEnd = 244433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x00225FFC File Offset: 0x002241FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244464, RefRangeEnd = 244465, XrefRangeStart = 244433, XrefRangeEnd = 244464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EjectTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x00226030 File Offset: 0x00224230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244465, XrefRangeEnd = 244475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x00226064 File Offset: 0x00224264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244480, RefRangeEnd = 244481, XrefRangeStart = 244475, XrefRangeEnd = 244480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PickupTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x002260A8 File Offset: 0x002242A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244482, RefRangeEnd = 244484, XrefRangeStart = 244481, XrefRangeEnd = 244482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x002260E4 File Offset: 0x002242E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244498, RefRangeEnd = 244499, XrefRangeStart = 244484, XrefRangeEnd = 244498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00226118 File Offset: 0x00224318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244499, XrefRangeEnd = 244502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_TrashGrabber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		public Equippable_TrashGrabber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x060080A2 RID: 32930 RVA: 0x00226154 File Offset: 0x00224354
		// (set) Token: 0x060080A3 RID: 32931 RVA: 0x0003CFF1 File Offset: 0x0003B1F1
		public unsafe static Equippable_TrashGrabber _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x0022617C File Offset: 0x0022437C
		// (set) Token: 0x060080A5 RID: 32933 RVA: 0x0003D003 File Offset: 0x0003B203
		public unsafe static float TrashDropSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&value));
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x00226198 File Offset: 0x00224398
		// (set) Token: 0x060080A7 RID: 32935 RVA: 0x0003D011 File Offset: 0x0003B211
		public unsafe Transform TrashContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x002261C8 File Offset: 0x002243C8
		// (set) Token: 0x060080A9 RID: 32937 RVA: 0x0003D030 File Offset: 0x0003B230
		public unsafe Transform TrashContent_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x002261F8 File Offset: 0x002243F8
		// (set) Token: 0x060080AB RID: 32939 RVA: 0x0003D04F File Offset: 0x0003B24F
		public unsafe Transform TrashContent_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x060080AC RID: 32940 RVA: 0x00226228 File Offset: 0x00224428
		// (set) Token: 0x060080AD RID: 32941 RVA: 0x0003D06E File Offset: 0x0003B26E
		public unsafe Animation GrabAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x060080AE RID: 32942 RVA: 0x00226258 File Offset: 0x00224458
		// (set) Token: 0x060080AF RID: 32943 RVA: 0x0003D08D File Offset: 0x0003B28D
		public unsafe Transform Bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x060080B0 RID: 32944 RVA: 0x00226288 File Offset: 0x00224488
		// (set) Token: 0x060080B1 RID: 32945 RVA: 0x0003D0AC File Offset: 0x0003B2AC
		public unsafe Transform BinRaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x060080B2 RID: 32946 RVA: 0x002262B8 File Offset: 0x002244B8
		// (set) Token: 0x060080B3 RID: 32947 RVA: 0x0003D0CB File Offset: 0x0003B2CB
		public unsafe AudioSourceController TrashDropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x060080B4 RID: 32948 RVA: 0x002262E8 File Offset: 0x002244E8
		// (set) Token: 0x060080B5 RID: 32949 RVA: 0x0003D0EA File Offset: 0x0003B2EA
		public unsafe float DropTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime)) = value;
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x060080B6 RID: 32950 RVA: 0x00226310 File Offset: 0x00224510
		// (set) Token: 0x060080B7 RID: 32951 RVA: 0x0003D105 File Offset: 0x0003B305
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x060080B8 RID: 32952 RVA: 0x00226338 File Offset: 0x00224538
		// (set) Token: 0x060080B9 RID: 32953 RVA: 0x0003D120 File Offset: 0x0003B320
		public unsafe Vector3 TrashDropOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset)) = value;
			}
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x00226360 File Offset: 0x00224560
		// (set) Token: 0x060080BB RID: 32955 RVA: 0x0003D13B File Offset: 0x0003B33B
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x00226390 File Offset: 0x00224590
		// (set) Token: 0x060080BD RID: 32957 RVA: 0x0003D15A File Offset: 0x0003B35A
		public unsafe float _currentDropTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x060080BE RID: 32958 RVA: 0x002263B8 File Offset: 0x002245B8
		// (set) Token: 0x060080BF RID: 32959 RVA: 0x0003D175 File Offset: 0x0003B375
		public unsafe float _timeSinceLastDrop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField)) = value;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x060080C0 RID: 32960 RVA: 0x002263E0 File Offset: 0x002245E0
		// (set) Token: 0x060080C1 RID: 32961 RVA: 0x0003D190 File Offset: 0x0003B390
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x060080C2 RID: 32962 RVA: 0x00226410 File Offset: 0x00224610
		// (set) Token: 0x060080C3 RID: 32963 RVA: 0x0003D1AF File Offset: 0x0003B3AF
		public unsafe Pose defaultBinPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition)) = value;
			}
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x060080C4 RID: 32964 RVA: 0x00226438 File Offset: 0x00224638
		// (set) Token: 0x060080C5 RID: 32965 RVA: 0x0003D1CA File Offset: 0x0003B3CA
		public unsafe Vector3 defaultBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale)) = value;
			}
		}

		// Token: 0x0400578F RID: 22415
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04005790 RID: 22416
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSpacing;

		// Token: 0x04005791 RID: 22417
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent;

		// Token: 0x04005792 RID: 22418
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Min;

		// Token: 0x04005793 RID: 22419
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Max;

		// Token: 0x04005794 RID: 22420
		private static readonly IntPtr NativeFieldInfoPtr_GrabAnim;

		// Token: 0x04005795 RID: 22421
		private static readonly IntPtr NativeFieldInfoPtr_Bin;

		// Token: 0x04005796 RID: 22422
		private static readonly IntPtr NativeFieldInfoPtr_BinRaisedPosition;

		// Token: 0x04005797 RID: 22423
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSound;

		// Token: 0x04005798 RID: 22424
		private static readonly IntPtr NativeFieldInfoPtr_DropTime;

		// Token: 0x04005799 RID: 22425
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x0400579A RID: 22426
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropOffset;

		// Token: 0x0400579B RID: 22427
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x0400579C RID: 22428
		private static readonly IntPtr NativeFieldInfoPtr__currentDropTime_k__BackingField;

		// Token: 0x0400579D RID: 22429
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField;

		// Token: 0x0400579E RID: 22430
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x0400579F RID: 22431
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinPosition;

		// Token: 0x040057A0 RID: 22432
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinScale;

		// Token: 0x040057A1 RID: 22433
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0;

		// Token: 0x040057A2 RID: 22434
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0;

		// Token: 0x040057A3 RID: 22435
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0;

		// Token: 0x040057A4 RID: 22436
		private static readonly IntPtr NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0;

		// Token: 0x040057A5 RID: 22437
		private static readonly IntPtr NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0;

		// Token: 0x040057A6 RID: 22438
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0;

		// Token: 0x040057A7 RID: 22439
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0;

		// Token: 0x040057A8 RID: 22440
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057A9 RID: 22441
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057AA RID: 22442
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057AB RID: 22443
		private static readonly IntPtr NativeMethodInfoPtr_EjectTrash_Private_Void_0;

		// Token: 0x040057AC RID: 22444
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040057AD RID: 22445
		private static readonly IntPtr NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0;

		// Token: 0x040057AE RID: 22446
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacity_Public_Int32_0;

		// Token: 0x040057AF RID: 22447
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x040057B0 RID: 22448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
