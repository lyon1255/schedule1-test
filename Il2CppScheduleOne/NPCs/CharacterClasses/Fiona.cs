using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000304 RID: 772
	public class Fiona : NPC
	{
		// Token: 0x060039F0 RID: 14832 RVA: 0x0012CE2C File Offset: 0x0012B02C
		// Note: this type is marked as 'beforefieldinit'.
		static Fiona()
		{
			Il2CppClassPointerStore<Fiona>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Fiona");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fiona>.NativeClassPtr);
			Fiona.NativeFieldInfoPtr_ShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fiona>.NativeClassPtr, "ShopInterface");
			Fiona.NativeFieldInfoPtr_OrderCompletedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fiona>.NativeClassPtr, "OrderCompletedLines");
			Fiona.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fiona>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted");
			Fiona.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fiona>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted");
			Fiona.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670048);
			Fiona.NativeMethodInfoPtr_OrderCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670049);
			Fiona.NativeMethodInfoPtr_ShopChoiceValid_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670050);
			Fiona.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670051);
			Fiona.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670052);
			Fiona.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670053);
			Fiona.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670054);
			Fiona.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fiona>.NativeClassPtr, 100670055);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x0012CF4C File Offset: 0x0012B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142076, XrefRangeEnd = 142098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fiona.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0012CF88 File Offset: 0x0012B188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142098, XrefRangeEnd = 142102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fiona.NativeMethodInfoPtr_OrderCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x0012CFBC File Offset: 0x0012B1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142102, XrefRangeEnd = 142105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShopChoiceValid(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Fiona.NativeMethodInfoPtr_ShopChoiceValid_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x0012D014 File Offset: 0x0012B214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fiona() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fiona>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fiona.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x0012D050 File Offset: 0x0012B250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fiona.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x0012D08C File Offset: 0x0012B28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142105, XrefRangeEnd = 142106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fiona.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x0012D0C8 File Offset: 0x0012B2C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fiona.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x0012D104 File Offset: 0x0012B304
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fiona.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x0001DAB2 File Offset: 0x0001BCB2
		public Fiona(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060039FA RID: 14842 RVA: 0x0012D140 File Offset: 0x0012B340
		// (set) Token: 0x060039FB RID: 14843 RVA: 0x0001DABB File Offset: 0x0001BCBB
		public unsafe ShopInterface ShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_ShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_ShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x0012D170 File Offset: 0x0012B370
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x0001DADA File Offset: 0x0001BCDA
		public unsafe Il2CppStringArray OrderCompletedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_OrderCompletedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_OrderCompletedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0012D1A0 File Offset: 0x0012B3A0
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x0001DAF9 File Offset: 0x0001BCF9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x0012D1C8 File Offset: 0x0012B3C8
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x0001DB14 File Offset: 0x0001BD14
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fiona.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeFieldInfoPtr_ShopInterface;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeFieldInfoPtr_OrderCompletedLines;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_OrderCompleted_Private_Void_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_ShopChoiceValid_Public_Boolean_byref_String_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
