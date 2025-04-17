using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005FA RID: 1530
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x060086E0 RID: 34528 RVA: 0x0023A3E4 File Offset: 0x002385E4
		// Note: this type is marked as 'beforefieldinit'.
		static MugshotGenerator()
		{
			Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "MugshotGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr);
			MugshotGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "OutputPath");
			MugshotGenerator.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Settings");
			MugshotGenerator.NativeFieldInfoPtr_MugshotRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "MugshotRig");
			MugshotGenerator.NativeFieldInfoPtr_Generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Generator");
			MugshotGenerator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "DefaultSettings");
			MugshotGenerator.NativeFieldInfoPtr_LookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "LookAtPosition");
			MugshotGenerator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "finalTexture");
			MugshotGenerator.NativeFieldInfoPtr_generate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "generate");
			MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680135);
			MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680136);
			MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680137);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680138);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680139);
			MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100680140);
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x0023A52C File Offset: 0x0023872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250994, XrefRangeEnd = 251000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x0023A568 File Offset: 0x00238768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251000, XrefRangeEnd = 251009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x0023A59C File Offset: 0x0023879C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251009, XrefRangeEnd = 251019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x0023A5D0 File Offset: 0x002387D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251019, XrefRangeEnd = 251020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x0023A604 File Offset: 0x00238804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251061, RefRangeEnd = 251063, XrefRangeStart = 251020, XrefRangeEnd = 251061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileToFile;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x0023A668 File Offset: 0x00238868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251063, XrefRangeEnd = 251066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MugshotGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x0004026F File Offset: 0x0003E46F
		public MugshotGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x060086E8 RID: 34536 RVA: 0x0023A6A4 File Offset: 0x002388A4
		// (set) Token: 0x060086E9 RID: 34537 RVA: 0x00040278 File Offset: 0x0003E478
		public unsafe string OutputPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x060086EA RID: 34538 RVA: 0x0023A6CC File Offset: 0x002388CC
		// (set) Token: 0x060086EB RID: 34539 RVA: 0x00040297 File Offset: 0x0003E497
		public unsafe AvatarSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x060086EC RID: 34540 RVA: 0x0023A6FC File Offset: 0x002388FC
		// (set) Token: 0x060086ED RID: 34541 RVA: 0x000402B6 File Offset: 0x0003E4B6
		public unsafe Avatar MugshotRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x060086EE RID: 34542 RVA: 0x0023A72C File Offset: 0x0023892C
		// (set) Token: 0x060086EF RID: 34543 RVA: 0x000402D5 File Offset: 0x0003E4D5
		public unsafe IconGenerator Generator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060086F0 RID: 34544 RVA: 0x0023A75C File Offset: 0x0023895C
		// (set) Token: 0x060086F1 RID: 34545 RVA: 0x000402F4 File Offset: 0x0003E4F4
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060086F2 RID: 34546 RVA: 0x0023A78C File Offset: 0x0023898C
		// (set) Token: 0x060086F3 RID: 34547 RVA: 0x00040313 File Offset: 0x0003E513
		public unsafe Transform LookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x0023A7BC File Offset: 0x002389BC
		// (set) Token: 0x060086F5 RID: 34549 RVA: 0x00040332 File Offset: 0x0003E532
		public unsafe Texture2D finalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x0023A7EC File Offset: 0x002389EC
		// (set) Token: 0x060086F7 RID: 34551 RVA: 0x00040351 File Offset: 0x0003E551
		public unsafe bool generate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate)) = value;
			}
		}

		// Token: 0x04005BC9 RID: 23497
		private static readonly IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x04005BCA RID: 23498
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04005BCB RID: 23499
		private static readonly IntPtr NativeFieldInfoPtr_MugshotRig;

		// Token: 0x04005BCC RID: 23500
		private static readonly IntPtr NativeFieldInfoPtr_Generator;

		// Token: 0x04005BCD RID: 23501
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005BCE RID: 23502
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPosition;

		// Token: 0x04005BCF RID: 23503
		private static readonly IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x04005BD0 RID: 23504
		private static readonly IntPtr NativeFieldInfoPtr_generate;

		// Token: 0x04005BD1 RID: 23505
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005BD2 RID: 23506
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005BD3 RID: 23507
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0;

		// Token: 0x04005BD4 RID: 23508
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_0;

		// Token: 0x04005BD5 RID: 23509
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0;

		// Token: 0x04005BD6 RID: 23510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF3 RID: 2803
		[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5B5 RID: 54709 RVA: 0x0032EAA8 File Offset: 0x0032CCA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "fileToFile");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "settings");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "callback");
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680141);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680142);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100680143);
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x0032EB60 File Offset: 0x0032CD60
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B7 RID: 54711 RVA: 0x0032EB9C File Offset: 0x0032CD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250984, XrefRangeEnd = 250989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5B8 RID: 54712 RVA: 0x0032EBDC File Offset: 0x0032CDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250989, XrefRangeEnd = 250994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateMugshot_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5B9 RID: 54713 RVA: 0x00067FA2 File Offset: 0x000661A2
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x0032EC18 File Offset: 0x0032CE18
			// (set) Token: 0x0600D5BB RID: 54715 RVA: 0x00067FAB File Offset: 0x000661AB
			public unsafe MugshotGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x0032EC48 File Offset: 0x0032CE48
			// (set) Token: 0x0600D5BD RID: 54717 RVA: 0x00067FCA File Offset: 0x000661CA
			public unsafe bool fileToFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile)) = value;
				}
			}

			// Token: 0x1700423B RID: 16955
			// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x0032EC70 File Offset: 0x0032CE70
			// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x00067FE5 File Offset: 0x000661E5
			public unsafe AvatarSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423C RID: 16956
			// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x0032ECA0 File Offset: 0x0032CEA0
			// (set) Token: 0x0600D5C1 RID: 54721 RVA: 0x00068004 File Offset: 0x00066204
			public unsafe Action<Texture2D> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FC0 RID: 36800
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FC1 RID: 36801
			private static readonly IntPtr NativeFieldInfoPtr_fileToFile;

			// Token: 0x04008FC2 RID: 36802
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04008FC3 RID: 36803
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008FC4 RID: 36804
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FC5 RID: 36805
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008FC6 RID: 36806
			private static readonly IntPtr NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0;

			// Token: 0x02000C67 RID: 3175
			[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0+<<GenerateMugshot>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E483 RID: 58499 RVA: 0x003593A0 File Offset: 0x003575A0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<<GenerateMugshot>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680144);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680145);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680146);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680147);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680148);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680149);
				}

				// Token: 0x0600E484 RID: 58500 RVA: 0x00359480 File Offset: 0x00357680
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E485 RID: 58501 RVA: 0x003594C8 File Offset: 0x003576C8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E486 RID: 58502 RVA: 0x003594FC File Offset: 0x003576FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250964, XrefRangeEnd = 250979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046FE RID: 18174
				// (get) Token: 0x0600E487 RID: 58503 RVA: 0x00359538 File Offset: 0x00357738
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E488 RID: 58504 RVA: 0x00359578 File Offset: 0x00357778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250979, XrefRangeEnd = 250984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046FF RID: 18175
				// (get) Token: 0x0600E489 RID: 58505 RVA: 0x003595AC File Offset: 0x003577AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E48A RID: 58506 RVA: 0x0006F6B5 File Offset: 0x0006D8B5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046FB RID: 18171
				// (get) Token: 0x0600E48B RID: 58507 RVA: 0x003595EC File Offset: 0x003577EC
				// (set) Token: 0x0600E48C RID: 58508 RVA: 0x0006F6BE File Offset: 0x0006D8BE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046FC RID: 18172
				// (get) Token: 0x0600E48D RID: 58509 RVA: 0x00359614 File Offset: 0x00357814
				// (set) Token: 0x0600E48E RID: 58510 RVA: 0x0006F6D9 File Offset: 0x0006D8D9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046FD RID: 18173
				// (get) Token: 0x0600E48F RID: 58511 RVA: 0x00359644 File Offset: 0x00357844
				// (set) Token: 0x0600E490 RID: 58512 RVA: 0x0006F6F8 File Offset: 0x0006D8F8
				public unsafe MugshotGenerator.__c__DisplayClass12_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098D9 RID: 39129
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098DA RID: 39130
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098DB RID: 39131
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098DC RID: 39132
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098DD RID: 39133
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098DE RID: 39134
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098DF RID: 39135
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098E0 RID: 39136
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098E1 RID: 39137
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
