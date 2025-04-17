using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000360 RID: 864
	public class RagdollBehaviour : Behaviour
	{
		// Token: 0x06004316 RID: 17174 RVA: 0x0014DC88 File Offset: 0x0014BE88
		// Note: this type is marked as 'beforefieldinit'.
		static RagdollBehaviour()
		{
			Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "RagdollBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr);
			RagdollBehaviour.NativeFieldInfoPtr_Seizure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "Seizure");
			RagdollBehaviour.NativeFieldInfoPtr_SeizureForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "SeizureForce");
			RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted");
			RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted");
			RagdollBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671486);
			RagdollBehaviour.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671487);
			RagdollBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671488);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671489);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671490);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671491);
			RagdollBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671492);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x0014DD94 File Offset: 0x0014BF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153488, XrefRangeEnd = 153491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x0014DDC8 File Offset: 0x0014BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153491, XrefRangeEnd = 153495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x0014DDFC File Offset: 0x0014BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153495, XrefRangeEnd = 153496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RagdollBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x0014DE38 File Offset: 0x0014C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153496, XrefRangeEnd = 153497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x0014DE74 File Offset: 0x0014C074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x0014DEB0 File Offset: 0x0014C0B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x0014DEEC File Offset: 0x0014C0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00020E1A File Offset: 0x0001F01A
		public RagdollBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x0014DF28 File Offset: 0x0014C128
		// (set) Token: 0x06004320 RID: 17184 RVA: 0x00020E23 File Offset: 0x0001F023
		public unsafe bool Seizure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_Seizure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_Seizure)) = value;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06004321 RID: 17185 RVA: 0x0014DF50 File Offset: 0x0014C150
		// (set) Token: 0x06004322 RID: 17186 RVA: 0x00020E3E File Offset: 0x0001F03E
		public unsafe float SeizureForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_SeizureForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_SeizureForce)) = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x0014DF78 File Offset: 0x0014C178
		// (set) Token: 0x06004324 RID: 17188 RVA: 0x00020E59 File Offset: 0x0001F059
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x0014DFA0 File Offset: 0x0014C1A0
		// (set) Token: 0x06004326 RID: 17190 RVA: 0x00020E74 File Offset: 0x0001F074
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeFieldInfoPtr_Seizure;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeFieldInfoPtr_SeizureForce;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
