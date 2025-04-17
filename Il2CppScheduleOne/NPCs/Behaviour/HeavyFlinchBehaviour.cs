using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035C RID: 860
	public class HeavyFlinchBehaviour : Behaviour
	{
		// Token: 0x06004217 RID: 16919 RVA: 0x0014A758 File Offset: 0x00148958
		// Note: this type is marked as 'beforefieldinit'.
		static HeavyFlinchBehaviour()
		{
			Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "HeavyFlinchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr);
			HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "FLINCH_DURATION");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "remainingFlinchTime");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted");
			HeavyFlinchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671347);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671348);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Flinch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671349);
			HeavyFlinchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671350);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671351);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671352);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671353);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671354);
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0014A878 File Offset: 0x00148A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152151, XrefRangeEnd = 152155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0014A8B4 File Offset: 0x00148AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0014A8F0 File Offset: 0x00148AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152155, XrefRangeEnd = 152156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyFlinchBehaviour.NativeMethodInfoPtr_Flinch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0014A924 File Offset: 0x00148B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeavyFlinchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyFlinchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0014A960 File Offset: 0x00148B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152156, XrefRangeEnd = 152157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0014A99C File Offset: 0x00148B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152157, XrefRangeEnd = 152158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0014A9D8 File Offset: 0x00148BD8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x0014AA14 File Offset: 0x00148C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000206EC File Offset: 0x0001E8EC
		public HeavyFlinchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004221 RID: 16929 RVA: 0x0014AA50 File Offset: 0x00148C50
		// (set) Token: 0x06004222 RID: 16930 RVA: 0x000206F5 File Offset: 0x0001E8F5
		public unsafe static float FLINCH_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION, (void*)(&value));
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x0014AA6C File Offset: 0x00148C6C
		// (set) Token: 0x06004224 RID: 16932 RVA: 0x00020703 File Offset: 0x0001E903
		public unsafe float remainingFlinchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime)) = value;
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x0014AA94 File Offset: 0x00148C94
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x0002071E File Offset: 0x0001E91E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x0014AABC File Offset: 0x00148CBC
		// (set) Token: 0x06004228 RID: 16936 RVA: 0x00020739 File Offset: 0x0001E939
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_DURATION;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeFieldInfoPtr_remainingFlinchTime;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_Flinch_Public_Void_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
