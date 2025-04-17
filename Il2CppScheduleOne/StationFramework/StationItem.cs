using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000591 RID: 1425
	public class StationItem : MonoBehaviour
	{
		// Token: 0x06007D70 RID: 32112 RVA: 0x00219B50 File Offset: 0x00217D50
		// Note: this type is marked as 'beforefieldinit'.
		static StationItem()
		{
			Il2CppClassPointerStore<StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem>.NativeClassPtr);
			StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<ActiveModules>k__BackingField");
			StationItem.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "Modules");
			StationItem.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "TrashPrefab");
			StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678982);
			StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678983);
			StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678984);
			StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678985);
			StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678986);
			StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678987);
			StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678988);
			StationItem.NativeMethodInfoPtr_GetModule_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678989);
			StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678990);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06007D71 RID: 32113 RVA: 0x00219C70 File Offset: 0x00217E70
		// (set) Token: 0x06007D72 RID: 32114 RVA: 0x00219CB0 File Offset: 0x00217EB0
		public unsafe List<ItemModule> ActiveModules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x00219CF4 File Offset: 0x00217EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237765, XrefRangeEnd = 237770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x00219D30 File Offset: 0x00217F30
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x00219D80 File Offset: 0x00217F80
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237792, RefRangeEnd = 237800, XrefRangeStart = 237770, XrefRangeEnd = 237792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x00219DB4 File Offset: 0x00217FB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 237805, RefRangeEnd = 237814, XrefRangeStart = 237800, XrefRangeEnd = 237805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x00219DE8 File Offset: 0x00217FE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 237832, RefRangeEnd = 237844, XrefRangeStart = 237814, XrefRangeEnd = 237832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x00219E24 File Offset: 0x00218024
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 237862, RefRangeEnd = 237899, XrefRangeStart = 237844, XrefRangeEnd = 237862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_GetModule_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x00219E60 File Offset: 0x00218060
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 237907, RefRangeEnd = 237912, XrefRangeStart = 237899, XrefRangeEnd = 237907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x0003B9FD File Offset: 0x00039BFD
		public StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x00219E9C File Offset: 0x0021809C
		// (set) Token: 0x06007D7C RID: 32124 RVA: 0x0003BA06 File Offset: 0x00039C06
		public unsafe List<ItemModule> _ActiveModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06007D7D RID: 32125 RVA: 0x00219ECC File Offset: 0x002180CC
		// (set) Token: 0x06007D7E RID: 32126 RVA: 0x0003BA25 File Offset: 0x00039C25
		public unsafe List<ItemModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06007D7F RID: 32127 RVA: 0x00219EFC File Offset: 0x002180FC
		// (set) Token: 0x06007D80 RID: 32128 RVA: 0x0003BA44 File Offset: 0x00039C44
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005554 RID: 21844
		private static readonly IntPtr NativeFieldInfoPtr__ActiveModules_k__BackingField;

		// Token: 0x04005555 RID: 21845
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04005556 RID: 21846
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x04005557 RID: 21847
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0;

		// Token: 0x04005558 RID: 21848
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0;

		// Token: 0x04005559 RID: 21849
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400555A RID: 21850
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0;

		// Token: 0x0400555B RID: 21851
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Void_0;

		// Token: 0x0400555C RID: 21852
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400555D RID: 21853
		private static readonly IntPtr NativeMethodInfoPtr_HasModule_Public_Boolean_0;

		// Token: 0x0400555E RID: 21854
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_T_0;

		// Token: 0x0400555F RID: 21855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D3DF RID: 54239 RVA: 0x00329680 File Offset: 0x00327880
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr);
				StationItem.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9");
				StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100678992);
				StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100678993);
			}

			// Token: 0x0600D3E0 RID: 54240 RVA: 0x00329738 File Offset: 0x00327938
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E1 RID: 54241 RVA: 0x00329774 File Offset: 0x00327974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237748, XrefRangeEnd = 237755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasModule_b__10_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3E2 RID: 54242 RVA: 0x00067239 File Offset: 0x00065439
			public __c__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B2 RID: 16818
			// (get) Token: 0x0600D3E3 RID: 54243 RVA: 0x003297C4 File Offset: 0x003279C4
			// (set) Token: 0x0600D3E4 RID: 54244 RVA: 0x00067242 File Offset: 0x00065442
			public unsafe static StationItem.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B3 RID: 16819
			// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x003297EC File Offset: 0x003279EC
			// (set) Token: 0x0600D3E6 RID: 54246 RVA: 0x00067254 File Offset: 0x00065454
			public unsafe static Predicate<ItemModule> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EB1 RID: 36529
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EB2 RID: 36530
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04008EB3 RID: 36531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB4 RID: 36532
			private static readonly IntPtr NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000ABC RID: 2748
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D3E7 RID: 54247 RVA: 0x00329814 File Offset: 0x00327A14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr);
				StationItem.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9");
				StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100678995);
				StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100678996);
			}

			// Token: 0x0600D3E8 RID: 54248 RVA: 0x003298CC File Offset: 0x00327ACC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E9 RID: 54249 RVA: 0x00329908 File Offset: 0x00327B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237755, XrefRangeEnd = 237765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetModule_b__11_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3EA RID: 54250 RVA: 0x00067266 File Offset: 0x00065466
			public __c__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0600D3EB RID: 54251 RVA: 0x00329958 File Offset: 0x00327B58
			// (set) Token: 0x0600D3EC RID: 54252 RVA: 0x0006726F File Offset: 0x0006546F
			public unsafe static StationItem.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B5 RID: 16821
			// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x00329980 File Offset: 0x00327B80
			// (set) Token: 0x0600D3EE RID: 54254 RVA: 0x00067281 File Offset: 0x00065481
			public unsafe static Predicate<ItemModule> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EB5 RID: 36533
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EB6 RID: 36534
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008EB7 RID: 36535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB8 RID: 36536
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000ABD RID: 2749
		private sealed class MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>
		{
			// Token: 0x04008EB9 RID: 36537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ABE RID: 2750
		private sealed class MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>
		{
			// Token: 0x04008EBA RID: 36538
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ABF RID: 2751
		private sealed class MethodInfoStoreGeneric_GetModule_Public_T_0<T>
		{
			// Token: 0x04008EBB RID: 36539
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_GetModule_Public_T_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
