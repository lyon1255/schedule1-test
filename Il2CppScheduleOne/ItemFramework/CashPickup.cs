using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D1 RID: 1489
	public class CashPickup : ItemPickup
	{
		// Token: 0x06008318 RID: 33560 RVA: 0x0022DBA0 File Offset: 0x0022BDA0
		// Note: this type is marked as 'beforefieldinit'.
		static CashPickup()
		{
			Il2CppClassPointerStore<CashPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashPickup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPickup>.NativeClassPtr);
			CashPickup.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "Value");
			CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted");
			CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted");
			CashPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679696);
			CashPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679697);
			CashPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679698);
			CashPickup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679699);
			CashPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679700);
			CashPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679701);
			CashPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679702);
			CashPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100679703);
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0022DCAC File Offset: 0x0022BEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246917, XrefRangeEnd = 246922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x0022DCE8 File Offset: 0x0022BEE8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x0022DD30 File Offset: 0x0022BF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246922, XrefRangeEnd = 246929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x0022DD6C File Offset: 0x0022BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246929, XrefRangeEnd = 246930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPickup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPickup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPickup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0022DDA8 File Offset: 0x0022BFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246930, XrefRangeEnd = 246937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0022DDE4 File Offset: 0x0022BFE4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x0022DE20 File Offset: 0x0022C020
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x0022DE5C File Offset: 0x0022C05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246937, XrefRangeEnd = 246957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008321 RID: 33569 RVA: 0x0003E4FD File Offset: 0x0003C6FD
		public CashPickup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x0022DE98 File Offset: 0x0022C098
		// (set) Token: 0x06008323 RID: 33571 RVA: 0x0003E506 File Offset: 0x0003C706
		public unsafe float Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x06008324 RID: 33572 RVA: 0x0022DEC0 File Offset: 0x0022C0C0
		// (set) Token: 0x06008325 RID: 33573 RVA: 0x0003E521 File Offset: 0x0003C721
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06008326 RID: 33574 RVA: 0x0022DEE8 File Offset: 0x0022C0E8
		// (set) Token: 0x06008327 RID: 33575 RVA: 0x0003E53C File Offset: 0x0003C73C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005933 RID: 22835
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04005934 RID: 22836
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005935 RID: 22837
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005936 RID: 22838
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0;

		// Token: 0x04005937 RID: 22839
		private static readonly IntPtr NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0;

		// Token: 0x04005938 RID: 22840
		private static readonly IntPtr NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0;

		// Token: 0x04005939 RID: 22841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400593A RID: 22842
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400593B RID: 22843
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400593C RID: 22844
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400593D RID: 22845
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
