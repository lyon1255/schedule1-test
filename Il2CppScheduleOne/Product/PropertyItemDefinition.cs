using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AD RID: 1453
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x06007FCE RID: 32718 RVA: 0x002235A4 File Offset: 0x002217A4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyItemDefinition()
		{
			Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr);
			PropertyItemDefinition.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, "Properties");
			PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679343);
			PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679344);
			PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679345);
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x00223624 File Offset: 0x00221824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243209, RefRangeEnd = 243210, XrefRangeStart = 243205, XrefRangeEnd = 243209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00223674 File Offset: 0x00221874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243214, RefRangeEnd = 243216, XrefRangeStart = 243210, XrefRangeEnd = 243214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x002236C4 File Offset: 0x002218C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243224, RefRangeEnd = 243225, XrefRangeStart = 243216, XrefRangeEnd = 243224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x0003C93E File Offset: 0x0003AB3E
		public PropertyItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x00223700 File Offset: 0x00221900
		// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x0003C947 File Offset: 0x0003AB47
		public unsafe List<Property> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005717 RID: 22295
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005718 RID: 22296
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0;

		// Token: 0x04005719 RID: 22297
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0;

		// Token: 0x0400571A RID: 22298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
