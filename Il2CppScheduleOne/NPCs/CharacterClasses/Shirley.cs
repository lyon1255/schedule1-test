using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.UI.Phone;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200033E RID: 830
	public class Shirley : Supplier
	{
		// Token: 0x06003D11 RID: 15633 RVA: 0x0013706C File Offset: 0x0013526C
		// Note: this type is marked as 'beforefieldinit'.
		static Shirley()
		{
			Il2CppClassPointerStore<Shirley>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Shirley");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shirley>.NativeClassPtr);
			Shirley.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shirley>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted");
			Shirley.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shirley>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted");
			Shirley.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_Void_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670419);
			Shirley.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670420);
			Shirley.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670421);
			Shirley.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670422);
			Shirley.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670423);
			Shirley.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shirley>.NativeClassPtr, 100670424);
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0013713C File Offset: 0x0013533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143189, XrefRangeEnd = 143205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shirley.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_Void_List_1_CartEntry_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00137198 File Offset: 0x00135398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143205, XrefRangeEnd = 143209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shirley() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shirley>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shirley.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x001371D4 File Offset: 0x001353D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shirley.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x00137210 File Offset: 0x00135410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shirley.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0013724C File Offset: 0x0013544C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shirley.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x00137288 File Offset: 0x00135488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shirley.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x0001EE2F File Offset: 0x0001D02F
		public Shirley(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x001372C4 File Offset: 0x001354C4
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x0001EE38 File Offset: 0x0001D038
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shirley.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shirley.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x001372EC File Offset: 0x001354EC
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x0001EE53 File Offset: 0x0001D053
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shirley.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shirley.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_Void_List_1_CartEntry_Single_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
