using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FD RID: 1789
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x0600A089 RID: 41097 RVA: 0x002869F4 File Offset: 0x00284BF4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorField()
		{
			Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr);
			CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "<value>k__BackingField");
			CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "selectedClothingDefinition");
			CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682933);
			CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682934);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682935);
			CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682936);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682937);
			CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682938);
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600A08A RID: 41098 RVA: 0x00286B00 File Offset: 0x00284D00
		// (set) Token: 0x0600A08B RID: 41099 RVA: 0x00286B3C File Offset: 0x00284D3C
		public unsafe T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x00286BCC File Offset: 0x00284DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282366, XrefRangeEnd = 282371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T ReadValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x00286C10 File Offset: 0x00284E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282371, XrefRangeEnd = 282381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00286C5C File Offset: 0x00284E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282382, RefRangeEnd = 282383, XrefRangeStart = 282381, XrefRangeEnd = 282382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00286C98 File Offset: 0x00284E98
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x0004EF73 File Offset: 0x0004D173
		public CharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600A091 RID: 41105 RVA: 0x00286CD4 File Offset: 0x00284ED4
		// (set) Token: 0x0600A092 RID: 41106 RVA: 0x00286CFC File Offset: 0x00284EFC
		public unsafe T _value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600A093 RID: 41107 RVA: 0x00286DA4 File Offset: 0x00284FA4
		// (set) Token: 0x0600A094 RID: 41108 RVA: 0x0004EF7C File Offset: 0x0004D17C
		public unsafe ClothingDefinition selectedClothingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BA0 RID: 27552
		private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

		// Token: 0x04006BA1 RID: 27553
		private static readonly IntPtr NativeFieldInfoPtr_selectedClothingDefinition;

		// Token: 0x04006BA2 RID: 27554
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_T_0;

		// Token: 0x04006BA3 RID: 27555
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Protected_set_Void_T_0;

		// Token: 0x04006BA4 RID: 27556
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0;

		// Token: 0x04006BA5 RID: 27557
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006BA6 RID: 27558
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BA7 RID: 27559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
