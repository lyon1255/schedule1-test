using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000614 RID: 1556
	public class ACSelection<T> : MonoBehaviour where T : UnityEngine.Object
	{
		// Token: 0x0600895C RID: 35164 RVA: 0x00241564 File Offset: 0x0023F764
		// Note: this type is marked as 'beforefieldinit'.
		static ACSelection()
		{
			Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSelection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr);
			ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "ButtonPrefab");
			ACSelection<T>.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "PropertyIndex");
			ACSelection<T>.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Options");
			ACSelection<T>.NativeFieldInfoPtr_Nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Nullable");
			ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "DefaultOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "buttons");
			ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "SelectedOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChange");
			ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChangeWithIndex");
			ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680402);
			ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680403);
			ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680404);
			ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680405);
			ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680406);
			ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680407);
			ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680408);
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x00241710 File Offset: 0x0023F910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253257, XrefRangeEnd = 253289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x0024174C File Offset: 0x0023F94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253293, RefRangeEnd = 253294, XrefRangeStart = 253289, XrefRangeEnd = 253293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOption(int index, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x00241798 File Offset: 0x0023F998
		[CallerCount(0)]
		public unsafe virtual void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x002417D4 File Offset: 0x0023F9D4
		[CallerCount(0)]
		public unsafe virtual string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x00241824 File Offset: 0x0023FA24
		[CallerCount(0)]
		public unsafe virtual int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x0024187C File Offset: 0x0023FA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253294, XrefRangeEnd = 253303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonHighlighted(int buttonIndex, bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x002418C8 File Offset: 0x0023FAC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253315, RefRangeEnd = 253318, XrefRangeStart = 253303, XrefRangeEnd = 253315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x00041915 File Offset: 0x0003FB15
		public ACSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06008965 RID: 35173 RVA: 0x00241904 File Offset: 0x0023FB04
		// (set) Token: 0x06008966 RID: 35174 RVA: 0x0004191E File Offset: 0x0003FB1E
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x06008967 RID: 35175 RVA: 0x00241934 File Offset: 0x0023FB34
		// (set) Token: 0x06008968 RID: 35176 RVA: 0x0004193D File Offset: 0x0003FB3D
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06008969 RID: 35177 RVA: 0x0024195C File Offset: 0x0023FB5C
		// (set) Token: 0x0600896A RID: 35178 RVA: 0x00041958 File Offset: 0x0003FB58
		public unsafe List<T> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600896B RID: 35179 RVA: 0x0024198C File Offset: 0x0023FB8C
		// (set) Token: 0x0600896C RID: 35180 RVA: 0x00041977 File Offset: 0x0003FB77
		public unsafe bool Nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable)) = value;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600896D RID: 35181 RVA: 0x002419B4 File Offset: 0x0023FBB4
		// (set) Token: 0x0600896E RID: 35182 RVA: 0x00041992 File Offset: 0x0003FB92
		public unsafe int DefaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex)) = value;
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600896F RID: 35183 RVA: 0x002419DC File Offset: 0x0023FBDC
		// (set) Token: 0x06008970 RID: 35184 RVA: 0x000419AD File Offset: 0x0003FBAD
		public unsafe List<GameObject> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06008971 RID: 35185 RVA: 0x00241A0C File Offset: 0x0023FC0C
		// (set) Token: 0x06008972 RID: 35186 RVA: 0x000419CC File Offset: 0x0003FBCC
		public unsafe int SelectedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex)) = value;
			}
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x00241A34 File Offset: 0x0023FC34
		// (set) Token: 0x06008974 RID: 35188 RVA: 0x000419E7 File Offset: 0x0003FBE7
		public unsafe UnityEvent<T> onValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x06008975 RID: 35189 RVA: 0x00241A64 File Offset: 0x0023FC64
		// (set) Token: 0x06008976 RID: 35190 RVA: 0x00041A06 File Offset: 0x0003FC06
		public unsafe UnityEvent<T, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D46 RID: 23878
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04005D47 RID: 23879
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x04005D48 RID: 23880
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04005D49 RID: 23881
		private static readonly IntPtr NativeFieldInfoPtr_Nullable;

		// Token: 0x04005D4A RID: 23882
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptionIndex;

		// Token: 0x04005D4B RID: 23883
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04005D4C RID: 23884
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOptionIndex;

		// Token: 0x04005D4D RID: 23885
		private static readonly IntPtr NativeFieldInfoPtr_onValueChange;

		// Token: 0x04005D4E RID: 23886
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x04005D4F RID: 23887
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005D50 RID: 23888
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0;

		// Token: 0x04005D51 RID: 23889
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04005D52 RID: 23890
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04005D53 RID: 23891
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04005D54 RID: 23892
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0;

		// Token: 0x04005D55 RID: 23893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B08 RID: 2824
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACSelection`1+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D66C RID: 54892 RVA: 0x00330A34 File Offset: 0x0032EC34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "<>c__DisplayClass9_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr);
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "index");
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680409);
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680410);
			}

			// Token: 0x0600D66D RID: 54893 RVA: 0x00330AEC File Offset: 0x0032ECEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D66E RID: 54894 RVA: 0x00330B28 File Offset: 0x0032ED28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253254, XrefRangeEnd = 253257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D66F RID: 54895 RVA: 0x000685B7 File Offset: 0x000667B7
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004271 RID: 17009
			// (get) Token: 0x0600D670 RID: 54896 RVA: 0x00330B5C File Offset: 0x0032ED5C
			// (set) Token: 0x0600D671 RID: 54897 RVA: 0x000685C0 File Offset: 0x000667C0
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004272 RID: 17010
			// (get) Token: 0x0600D672 RID: 54898 RVA: 0x00330B84 File Offset: 0x0032ED84
			// (set) Token: 0x0600D673 RID: 54899 RVA: 0x000685DB File Offset: 0x000667DB
			public unsafe ACSelection<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009031 RID: 36913
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009032 RID: 36914
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009033 RID: 36915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009034 RID: 36916
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
