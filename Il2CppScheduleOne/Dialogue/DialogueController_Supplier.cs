using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000434 RID: 1076
	public class DialogueController_Supplier : DialogueController
	{
		// Token: 0x06005E84 RID: 24196 RVA: 0x001B31A0 File Offset: 0x001B13A0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Supplier()
		{
			Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr);
			DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, "<Supplier>k__BackingField");
			DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675345);
			DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675346);
			DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675347);
			DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675348);
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x001B3234 File Offset: 0x001B1434
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x001B3274 File Offset: 0x001B1474
		public unsafe Supplier Supplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x001B32B8 File Offset: 0x001B14B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197259, XrefRangeEnd = 197265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x001B32F4 File Offset: 0x001B14F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197265, XrefRangeEnd = 197269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0002C909 File Offset: 0x0002AB09
		public DialogueController_Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005E8A RID: 24202 RVA: 0x001B3330 File Offset: 0x001B1530
		// (set) Token: 0x06005E8B RID: 24203 RVA: 0x0002C912 File Offset: 0x0002AB12
		public unsafe Supplier _Supplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040A5 RID: 16549
		private static readonly IntPtr NativeFieldInfoPtr__Supplier_k__BackingField;

		// Token: 0x040040A6 RID: 16550
		private static readonly IntPtr NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0;

		// Token: 0x040040A7 RID: 16551
		private static readonly IntPtr NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0;

		// Token: 0x040040A8 RID: 16552
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040040A9 RID: 16553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
