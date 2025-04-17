using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200030C RID: 780
	public class Herbert : NPC
	{
		// Token: 0x06003A60 RID: 14944 RVA: 0x0012E424 File Offset: 0x0012C624
		// Note: this type is marked as 'beforefieldinit'.
		static Herbert()
		{
			Il2CppClassPointerStore<Herbert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Herbert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Herbert>.NativeClassPtr);
			Herbert.NativeFieldInfoPtr_ShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Herbert>.NativeClassPtr, "ShopInterface");
			Herbert.NativeFieldInfoPtr_OrderCompletedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Herbert>.NativeClassPtr, "OrderCompletedLines");
			Herbert.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Herbert>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted");
			Herbert.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Herbert>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted");
			Herbert.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670096);
			Herbert.NativeMethodInfoPtr_OrderCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670097);
			Herbert.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670098);
			Herbert.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670099);
			Herbert.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670100);
			Herbert.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670101);
			Herbert.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Herbert>.NativeClassPtr, 100670102);
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x0012E530 File Offset: 0x0012C730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142216, XrefRangeEnd = 142225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Herbert.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x0012E56C File Offset: 0x0012C76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142225, XrefRangeEnd = 142237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Herbert.NativeMethodInfoPtr_OrderCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x0012E5A0 File Offset: 0x0012C7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Herbert() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Herbert>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Herbert.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x0012E5DC File Offset: 0x0012C7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Herbert.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x0012E618 File Offset: 0x0012C818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Herbert.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x0012E654 File Offset: 0x0012C854
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Herbert.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x0012E690 File Offset: 0x0012C890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Herbert.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x0001DD5E File Offset: 0x0001BF5E
		public Herbert(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x0012E6CC File Offset: 0x0012C8CC
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x0001DD67 File Offset: 0x0001BF67
		public unsafe ShopInterface ShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_ShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_ShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x0012E6FC File Offset: 0x0012C8FC
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x0001DD86 File Offset: 0x0001BF86
		public unsafe Il2CppStringArray OrderCompletedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_OrderCompletedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_OrderCompletedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0012E72C File Offset: 0x0012C92C
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x0001DDA5 File Offset: 0x0001BFA5
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x0012E754 File Offset: 0x0012C954
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Herbert.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeFieldInfoPtr_ShopInterface;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeFieldInfoPtr_OrderCompletedLines;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeMethodInfoPtr_OrderCompleted_Private_Void_0;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
