using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020002FF RID: 767
	public class Dan : NPC
	{
		// Token: 0x060039AF RID: 14767 RVA: 0x0012C0F4 File Offset: 0x0012A2F4
		// Note: this type is marked as 'beforefieldinit'.
		static Dan()
		{
			Il2CppClassPointerStore<Dan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Dan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dan>.NativeClassPtr);
			Dan.NativeFieldInfoPtr_ShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dan>.NativeClassPtr, "ShopInterface");
			Dan.NativeFieldInfoPtr_OrderCompletedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dan>.NativeClassPtr, "OrderCompletedLines");
			Dan.NativeFieldInfoPtr_onGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dan>.NativeClassPtr, "onGreeting");
			Dan.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dan>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted");
			Dan.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dan>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted");
			Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670019);
			Dan.NativeMethodInfoPtr_OrderCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670020);
			Dan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670021);
			Dan.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670022);
			Dan.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670023);
			Dan.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670024);
			Dan.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dan>.NativeClassPtr, 100670025);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0012C214 File Offset: 0x0012A414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142012, XrefRangeEnd = 142021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0012C250 File Offset: 0x0012A450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142021, XrefRangeEnd = 142041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dan.NativeMethodInfoPtr_OrderCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0012C284 File Offset: 0x0012A484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0012C2C0 File Offset: 0x0012A4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142041, XrefRangeEnd = 142042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dan.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0012C2FC File Offset: 0x0012A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142042, XrefRangeEnd = 142043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dan.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0012C338 File Offset: 0x0012A538
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dan.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0012C374 File Offset: 0x0012A574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dan.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0001D91A File Offset: 0x0001BB1A
		public Dan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x0012C3B0 File Offset: 0x0012A5B0
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x0001D923 File Offset: 0x0001BB23
		public unsafe ShopInterface ShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_ShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_ShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x0012C3E0 File Offset: 0x0012A5E0
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x0001D942 File Offset: 0x0001BB42
		public unsafe Il2CppStringArray OrderCompletedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_OrderCompletedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_OrderCompletedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0012C410 File Offset: 0x0012A610
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x0001D961 File Offset: 0x0001BB61
		public unsafe UnityEvent onGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_onGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_onGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x0012C440 File Offset: 0x0012A640
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x0001D980 File Offset: 0x0001BB80
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x0012C468 File Offset: 0x0012A668
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x0001D99B File Offset: 0x0001BB9B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dan.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeFieldInfoPtr_ShopInterface;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeFieldInfoPtr_OrderCompletedLines;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeFieldInfoPtr_onGreeting;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr_OrderCompleted_Private_Void_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
