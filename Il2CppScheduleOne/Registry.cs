using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000168 RID: 360
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x000CA830 File Offset: 0x000C8A30
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_ObjectRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegistry");
			Registry.NativeFieldInfoPtr_ItemRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegistry");
			Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemsAddedAtRuntime");
			Registry.NativeFieldInfoPtr_ItemDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemDictionary");
			Registry.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "Seeds");
			Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666568);
			Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666569);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666570);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666571);
			Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666572);
			Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666573);
			Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666574);
			Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666575);
			Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666576);
			Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666577);
			Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666578);
			Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666579);
			Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666580);
			Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666581);
			Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666582);
			Registry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666583);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000CAA04 File Offset: 0x000C8C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104266, XrefRangeEnd = 104310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000CAA40 File Offset: 0x000C8C40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104329, RefRangeEnd = 104332, XrefRangeStart = 104310, XrefRangeEnd = 104329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetPrefab(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000CAA84 File Offset: 0x000C8C84
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 104349, RefRangeEnd = 104417, XrefRangeStart = 104332, XrefRangeEnd = 104349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemDefinition GetItem(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000CAAC8 File Offset: 0x000C8CC8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 104426, RefRangeEnd = 104441, XrefRangeStart = 104417, XrefRangeEnd = 104426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetItem<T>(string ID) where T : ItemDefinition
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000CAB08 File Offset: 0x000C8D08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104454, RefRangeEnd = 104457, XrefRangeStart = 104441, XrefRangeEnd = 104454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition _GetItem(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000CAB58 File Offset: 0x000C8D58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 104484, RefRangeEnd = 104490, XrefRangeStart = 104457, XrefRangeEnd = 104484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Constructable GetConstructable(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000CAB9C File Offset: 0x000C8D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104490, XrefRangeEnd = 104492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHash(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000CABE0 File Offset: 0x000C8DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104492, XrefRangeEnd = 104501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAssetsAndPrefab(string originalString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000CAC1C File Offset: 0x000C8E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104501, XrefRangeEnd = 104516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000CAC58 File Offset: 0x000C8E58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104556, RefRangeEnd = 104559, XrefRangeStart = 104516, XrefRangeEnd = 104556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000CAC9C File Offset: 0x000C8E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104577, RefRangeEnd = 104579, XrefRangeStart = 104559, XrefRangeEnd = 104577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToItemDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000CACE0 File Offset: 0x000C8EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104579, XrefRangeEnd = 104584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x000CAD24 File Offset: 0x000C8F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104584, XrefRangeEnd = 104636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRuntimeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000CAD58 File Offset: 0x000C8F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104636, XrefRangeEnd = 104657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000CAD9C File Offset: 0x000C8F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104657, XrefRangeEnd = 104727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOrderedUnlocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000CADD0 File Offset: 0x000C8FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104727, XrefRangeEnd = 104763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Registry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0001087C File Offset: 0x0000EA7C
		public Registry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000CAE0C File Offset: 0x000C900C
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00010885 File Offset: 0x0000EA85
		public unsafe List<Registry.ObjectRegister> ObjectRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ObjectRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000CAE3C File Offset: 0x000C903C
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000108A4 File Offset: 0x0000EAA4
		public unsafe List<Registry.ItemRegister> ItemRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000CAE6C File Offset: 0x000C906C
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x000108C3 File Offset: 0x0000EAC3
		public unsafe List<Registry.ItemRegister> ItemsAddedAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x000CAE9C File Offset: 0x000C909C
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x000108E2 File Offset: 0x0000EAE2
		public unsafe Dictionary<int, Registry.ItemRegister> ItemDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x000CAECC File Offset: 0x000C90CC
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00010901 File Offset: 0x0000EB01
		public unsafe List<SeedDefinition> Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SeedDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_ObjectRegistry;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_ItemRegistry;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_ItemsAddedAtRuntime;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_ItemDictionary;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_T_String_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200089C RID: 2204
		[Serializable]
		public class ObjectRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C291 RID: 49809 RVA: 0x002F84D4 File Offset: 0x002F66D4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectRegister()
			{
				Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr);
				Registry.ObjectRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "ID");
				Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "AssetPath");
				Registry.ObjectRegister.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "Prefab");
				Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, 100666584);
			}

			// Token: 0x0600C292 RID: 49810 RVA: 0x002F8550 File Offset: 0x002F6750
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C293 RID: 49811 RVA: 0x0005EACC File Offset: 0x0005CCCC
			public ObjectRegister(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CC5 RID: 15557
			// (get) Token: 0x0600C294 RID: 49812 RVA: 0x002F858C File Offset: 0x002F678C
			// (set) Token: 0x0600C295 RID: 49813 RVA: 0x0005EAD5 File Offset: 0x0005CCD5
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CC6 RID: 15558
			// (get) Token: 0x0600C296 RID: 49814 RVA: 0x002F85B4 File Offset: 0x002F67B4
			// (set) Token: 0x0600C297 RID: 49815 RVA: 0x0005EAF4 File Offset: 0x0005CCF4
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CC7 RID: 15559
			// (get) Token: 0x0600C298 RID: 49816 RVA: 0x002F85DC File Offset: 0x002F67DC
			// (set) Token: 0x0600C299 RID: 49817 RVA: 0x0005EB13 File Offset: 0x0005CD13
			public unsafe NetworkObject Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083C5 RID: 33733
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040083C6 RID: 33734
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040083C7 RID: 33735
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x040083C8 RID: 33736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089D RID: 2205
		[Serializable]
		public class ItemRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C29A RID: 49818 RVA: 0x002F860C File Offset: 0x002F680C
			// Note: this type is marked as 'beforefieldinit'.
			static ItemRegister()
			{
				Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr);
				Registry.ItemRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "ID");
				Registry.ItemRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "AssetPath");
				Registry.ItemRegister.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "Definition");
				Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, 100666585);
			}

			// Token: 0x0600C29B RID: 49819 RVA: 0x002F8688 File Offset: 0x002F6888
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C29C RID: 49820 RVA: 0x0005EB32 File Offset: 0x0005CD32
			public ItemRegister(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CC8 RID: 15560
			// (get) Token: 0x0600C29D RID: 49821 RVA: 0x002F86C4 File Offset: 0x002F68C4
			// (set) Token: 0x0600C29E RID: 49822 RVA: 0x0005EB3B File Offset: 0x0005CD3B
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CC9 RID: 15561
			// (get) Token: 0x0600C29F RID: 49823 RVA: 0x002F86EC File Offset: 0x002F68EC
			// (set) Token: 0x0600C2A0 RID: 49824 RVA: 0x0005EB5A File Offset: 0x0005CD5A
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CCA RID: 15562
			// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x002F8714 File Offset: 0x002F6914
			// (set) Token: 0x0600C2A2 RID: 49826 RVA: 0x0005EB79 File Offset: 0x0005CD79
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083C9 RID: 33737
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040083CA RID: 33738
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040083CB RID: 33739
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040083CC RID: 33740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089E RID: 2206
		[ObfuscatedName("ScheduleOne.Registry+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C2A3 RID: 49827 RVA: 0x002F8744 File Offset: 0x002F6944
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Registry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr);
				Registry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9");
				Registry.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__21_0");
				Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666587);
				Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__21_0_Internal_Int32_ItemDefinition_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666588);
			}

			// Token: 0x0600C2A4 RID: 49828 RVA: 0x002F87C0 File Offset: 0x002F69C0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2A5 RID: 49829 RVA: 0x002F87FC File Offset: 0x002F69FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104233, XrefRangeEnd = 104237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LogOrderedUnlocks_b__21_0(ItemDefinition x, ItemDefinition y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__21_0_Internal_Int32_ItemDefinition_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2A6 RID: 49830 RVA: 0x0005EB98 File Offset: 0x0005CD98
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCB RID: 15563
			// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x002F885C File Offset: 0x002F6A5C
			// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x0005EBA1 File Offset: 0x0005CDA1
			public unsafe static Registry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CCC RID: 15564
			// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x002F8884 File Offset: 0x002F6A84
			// (set) Token: 0x0600C2AA RID: 49834 RVA: 0x0005EBB3 File Offset: 0x0005CDB3
			public unsafe static Comparison<ItemDefinition> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083CD RID: 33741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040083CE RID: 33742
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x040083CF RID: 33743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083D0 RID: 33744
			private static readonly IntPtr NativeMethodInfoPtr__LogOrderedUnlocks_b__21_0_Internal_Int32_ItemDefinition_ItemDefinition_0;
		}

		// Token: 0x0200089F RID: 2207
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2AB RID: 49835 RVA: 0x002F88AC File Offset: 0x002F6AAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr);
				Registry.__c__DisplayClass20_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr, "item");
				Registry.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr, 100666589);
				Registry.__c__DisplayClass20_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr, 100666590);
			}

			// Token: 0x0600C2AC RID: 49836 RVA: 0x002F8914 File Offset: 0x002F6B14
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2AD RID: 49837 RVA: 0x002F8950 File Offset: 0x002F6B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104237, XrefRangeEnd = 104242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromRegistry_b__0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass20_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2AE RID: 49838 RVA: 0x0005EBC5 File Offset: 0x0005CDC5
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCD RID: 15565
			// (get) Token: 0x0600C2AF RID: 49839 RVA: 0x002F89A0 File Offset: 0x002F6BA0
			// (set) Token: 0x0600C2B0 RID: 49840 RVA: 0x0005EBCE File Offset: 0x0005CDCE
			public unsafe ItemDefinition item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass20_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass20_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083D1 RID: 33745
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x040083D2 RID: 33746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083D3 RID: 33747
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0;
		}

		// Token: 0x020008A0 RID: 2208
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2B1 RID: 49841 RVA: 0x002F89D0 File Offset: 0x002F6BD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr);
				Registry.__c__DisplayClass8_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr, "id");
				Registry.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr, 100666591);
				Registry.__c__DisplayClass8_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr, 100666592);
			}

			// Token: 0x0600C2B2 RID: 49842 RVA: 0x002F8A38 File Offset: 0x002F6C38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2B3 RID: 49843 RVA: 0x002F8A74 File Offset: 0x002F6C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104242, XrefRangeEnd = 104266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPrefab_b__0(Registry.ObjectRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass8_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2B4 RID: 49844 RVA: 0x0005EBED File Offset: 0x0005CDED
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCE RID: 15566
			// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x002F8AC4 File Offset: 0x002F6CC4
			// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x0005EBF6 File Offset: 0x0005CDF6
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass8_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass8_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040083D4 RID: 33748
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040083D5 RID: 33749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083D6 RID: 33750
			private static readonly IntPtr NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0;
		}

		// Token: 0x020008A1 RID: 2209
		private sealed class MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>
		{
			// Token: 0x040083D7 RID: 33751
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0, Il2CppClassPointerStore<Registry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
