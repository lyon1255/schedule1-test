using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200030A RID: 778
	public class Greg : NPC
	{
		// Token: 0x06003A4A RID: 14922 RVA: 0x0012DFB4 File Offset: 0x0012C1B4
		// Note: this type is marked as 'beforefieldinit'.
		static Greg()
		{
			Il2CppClassPointerStore<Greg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Greg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Greg>.NativeClassPtr);
			Greg.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Greg>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted");
			Greg.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Greg>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted");
			Greg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Greg>.NativeClassPtr, 100670086);
			Greg.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Greg>.NativeClassPtr, 100670087);
			Greg.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Greg>.NativeClassPtr, 100670088);
			Greg.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Greg>.NativeClassPtr, 100670089);
			Greg.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Greg>.NativeClassPtr, 100670090);
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x0012E070 File Offset: 0x0012C270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Greg() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Greg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Greg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x0012E0AC File Offset: 0x0012C2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Greg.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0012E0E8 File Offset: 0x0012C2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Greg.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x0012E124 File Offset: 0x0012C324
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Greg.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x0012E160 File Offset: 0x0012C360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Greg.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
		public Greg(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x0012E19C File Offset: 0x0012C39C
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x0001DCE9 File Offset: 0x0001BEE9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Greg.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Greg.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x0012E1C4 File Offset: 0x0012C3C4
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x0001DD04 File Offset: 0x0001BF04
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Greg.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Greg.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
