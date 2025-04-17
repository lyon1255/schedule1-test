using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DF RID: 1503
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x0600836D RID: 33645 RVA: 0x0022EF88 File Offset: 0x0022D188
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemDefinition()
		{
			Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr);
			IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, "DefaultValue");
			IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100679740);
			IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100679741);
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0022EFF4 File Offset: 0x0022D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247178, XrefRangeEnd = 247182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0022F04C File Offset: 0x0022D24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0003E671 File Offset: 0x0003C871
		public IntegerItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06008371 RID: 33649 RVA: 0x0022F088 File Offset: 0x0022D288
		// (set) Token: 0x06008372 RID: 33650 RVA: 0x0003E67A File Offset: 0x0003C87A
		public unsafe int DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x04005972 RID: 22898
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x04005973 RID: 22899
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005974 RID: 22900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
