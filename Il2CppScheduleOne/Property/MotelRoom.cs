using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050D RID: 1293
	public class MotelRoom : Property
	{
		// Token: 0x06007276 RID: 29302 RVA: 0x001F4824 File Offset: 0x001F2A24
		// Note: this type is marked as 'beforefieldinit'.
		static MotelRoom()
		{
			Il2CppClassPointerStore<MotelRoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "MotelRoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr);
			MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted");
			MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted");
			MotelRoom.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677660);
			MotelRoom.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677661);
			MotelRoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677662);
			MotelRoom.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677663);
			MotelRoom.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677664);
			MotelRoom.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677665);
			MotelRoom.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100677666);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x001F4908 File Offset: 0x001F2B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224298, XrefRangeEnd = 224302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x001F4944 File Offset: 0x001F2B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224302, XrefRangeEnd = 224386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x001F4978 File Offset: 0x001F2B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224386, XrefRangeEnd = 224390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotelRoom() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x001F49B4 File Offset: 0x001F2BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224390, XrefRangeEnd = 224391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x001F49F0 File Offset: 0x001F2BF0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x001F4A2C File Offset: 0x001F2C2C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x001F4A68 File Offset: 0x001F2C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x000366E6 File Offset: 0x000348E6
		public MotelRoom(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x001F4AA4 File Offset: 0x001F2CA4
		// (set) Token: 0x06007280 RID: 29312 RVA: 0x000366EF File Offset: 0x000348EF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x001F4ACC File Offset: 0x001F2CCC
		// (set) Token: 0x06007282 RID: 29314 RVA: 0x0003670A File Offset: 0x0003490A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004E1E RID: 19998
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004E1F RID: 19999
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004E20 RID: 20000
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004E21 RID: 20001
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004E22 RID: 20002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E23 RID: 20003
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004E24 RID: 20004
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004E25 RID: 20005
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004E26 RID: 20006
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A84 RID: 2692
		[ObfuscatedName("ScheduleOne.Property.MotelRoom+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D208 RID: 53768 RVA: 0x003242D8 File Offset: 0x003224D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr);
				MotelRoom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, "<>9");
				MotelRoom.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, "<>9__1_0");
				MotelRoom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, 100677668);
				MotelRoom.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, 100677669);
			}

			// Token: 0x0600D209 RID: 53769 RVA: 0x00324354 File Offset: 0x00322554
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D20A RID: 53770 RVA: 0x00324390 File Offset: 0x00322590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224294, XrefRangeEnd = 224298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__1_0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D20B RID: 53771 RVA: 0x00066489 File Offset: 0x00064689
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004132 RID: 16690
			// (get) Token: 0x0600D20C RID: 53772 RVA: 0x003243E0 File Offset: 0x003225E0
			// (set) Token: 0x0600D20D RID: 53773 RVA: 0x00066492 File Offset: 0x00064692
			public unsafe static MotelRoom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotelRoom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotelRoom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotelRoom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004133 RID: 16691
			// (get) Token: 0x0600D20E RID: 53774 RVA: 0x00324408 File Offset: 0x00322608
			// (set) Token: 0x0600D20F RID: 53775 RVA: 0x000664A4 File Offset: 0x000646A4
			public unsafe static Predicate<Additive> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotelRoom.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotelRoom.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DAD RID: 36269
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DAE RID: 36270
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008DAF RID: 36271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB0 RID: 36272
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_Additive_0;
		}
	}
}
