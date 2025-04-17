using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000667 RID: 1639
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x06009269 RID: 37481 RVA: 0x0025C2EC File Offset: 0x0025A4EC
		// Note: this type is marked as 'beforefieldinit'.
		static StorageMenu()
		{
			Il2CppClassPointerStore<StorageMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "StorageMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr);
			StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<OpenedStorageEntity>k__BackingField");
			StorageMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Canvas");
			StorageMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Container");
			StorageMenu.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "TitleLabel");
			StorageMenu.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SubtitleLabel");
			StorageMenu.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotContainer");
			StorageMenu.NativeFieldInfoPtr_SlotsUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotsUIs");
			StorageMenu.NativeFieldInfoPtr_SlotGridLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotGridLayout");
			StorageMenu.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "CloseButton");
			StorageMenu.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "onClosed");
			StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681480);
			StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681481);
			StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681482);
			StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681483);
			StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681484);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681485);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681486);
			StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681487);
			StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681488);
			StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681489);
			StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681490);
			StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681491);
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600926A RID: 37482 RVA: 0x0025C4E8 File Offset: 0x0025A6E8
		// (set) Token: 0x0600926B RID: 37483 RVA: 0x0025C524 File Offset: 0x0025A724
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600926C RID: 37484 RVA: 0x0025C564 File Offset: 0x0025A764
		// (set) Token: 0x0600926D RID: 37485 RVA: 0x0025C5A4 File Offset: 0x0025A7A4
		public unsafe StorageEntity OpenedStorageEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x0025C5E8 File Offset: 0x0025A7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264412, XrefRangeEnd = 264429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x0025C624 File Offset: 0x0025A824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264429, XrefRangeEnd = 264433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x0025C698 File Offset: 0x0025A898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264433, XrefRangeEnd = 264436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(StorageEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x0025C6E8 File Offset: 0x0025A8E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264514, RefRangeEnd = 264516, XrefRangeStart = 264436, XrefRangeEnd = 264514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x0025C750 File Offset: 0x0025A950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264516, XrefRangeEnd = 264522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x0025C784 File Offset: 0x0025A984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264522, XrefRangeEnd = 264567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CloseMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x0025C7C0 File Offset: 0x0025A9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264567, XrefRangeEnd = 264571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x0025C804 File Offset: 0x0025AA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264571, XrefRangeEnd = 264574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00046D6A File Offset: 0x00044F6A
		public StorageMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x0025C840 File Offset: 0x0025AA40
		// (set) Token: 0x06009278 RID: 37496 RVA: 0x00046D73 File Offset: 0x00044F73
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x0025C868 File Offset: 0x0025AA68
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x00046D8E File Offset: 0x00044F8E
		public unsafe StorageEntity _OpenedStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x0025C898 File Offset: 0x0025AA98
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x00046DAD File Offset: 0x00044FAD
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600927D RID: 37501 RVA: 0x0025C8C8 File Offset: 0x0025AAC8
		// (set) Token: 0x0600927E RID: 37502 RVA: 0x00046DCC File Offset: 0x00044FCC
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x0025C8F8 File Offset: 0x0025AAF8
		// (set) Token: 0x06009280 RID: 37504 RVA: 0x00046DEB File Offset: 0x00044FEB
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x0025C928 File Offset: 0x0025AB28
		// (set) Token: 0x06009282 RID: 37506 RVA: 0x00046E0A File Offset: 0x0004500A
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x0025C958 File Offset: 0x0025AB58
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x00046E29 File Offset: 0x00045029
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x0025C988 File Offset: 0x0025AB88
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x00046E48 File Offset: 0x00045048
		public unsafe Il2CppReferenceArray<ItemSlotUI> SlotsUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06009287 RID: 37511 RVA: 0x0025C9B8 File Offset: 0x0025ABB8
		// (set) Token: 0x06009288 RID: 37512 RVA: 0x00046E67 File Offset: 0x00045067
		public unsafe GridLayoutGroup SlotGridLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06009289 RID: 37513 RVA: 0x0025C9E8 File Offset: 0x0025ABE8
		// (set) Token: 0x0600928A RID: 37514 RVA: 0x00046E86 File Offset: 0x00045086
		public unsafe RectTransform CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x0025CA18 File Offset: 0x0025AC18
		// (set) Token: 0x0600928C RID: 37516 RVA: 0x00046EA5 File Offset: 0x000450A5
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040062EA RID: 25322
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040062EB RID: 25323
		private static readonly IntPtr NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField;

		// Token: 0x040062EC RID: 25324
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040062ED RID: 25325
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040062EE RID: 25326
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040062EF RID: 25327
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040062F0 RID: 25328
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x040062F1 RID: 25329
		private static readonly IntPtr NativeFieldInfoPtr_SlotsUIs;

		// Token: 0x040062F2 RID: 25330
		private static readonly IntPtr NativeFieldInfoPtr_SlotGridLayout;

		// Token: 0x040062F3 RID: 25331
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x040062F4 RID: 25332
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x040062F5 RID: 25333
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040062F6 RID: 25334
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040062F7 RID: 25335
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0;

		// Token: 0x040062F8 RID: 25336
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0;

		// Token: 0x040062F9 RID: 25337
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040062FA RID: 25338
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0;

		// Token: 0x040062FB RID: 25339
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0;

		// Token: 0x040062FC RID: 25340
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0;

		// Token: 0x040062FD RID: 25341
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040062FE RID: 25342
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0;

		// Token: 0x040062FF RID: 25343
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006300 RID: 25344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
